using OpenExchange.Core.Interfaces;
using OpenExchange.Security.Credentials;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace OpenExchange.BitcoinDe.Authentication
{
    public class BitcoinDeRequestSigner : IRequestSigner
    {
        private readonly ICredentialProvider _credentialProvider;
        private long _lastNonce;
        public BitcoinDeRequestSigner(ICredentialProvider credentialProvider)
        {
            _credentialProvider = credentialProvider;
        }

        public async Task SignAsync(HttpRequestMessage request, CancellationToken cancellationToken = default)
        {
            if (request.RequestUri == null)
                throw new InvalidOperationException("RequestUri must not be null.");

            var credentials = _credentialProvider.GetCredentials();

            var nonce = CreateNonce();

            var httpMethod = request.Method.Method.ToUpperInvariant();
            var uri = request.RequestUri.AbsoluteUri;
            var postParameterString = await GetNormalizedPostParameterStringAsync(
                request,
                cancellationToken);

            var postParameterMd5 = ComputeMd5Lowercase(postParameterString);

            var hmacData = string.Join(
                "#",
                httpMethod,
                uri,
                credentials.ApiKey,
                nonce.ToString(CultureInfo.InvariantCulture),
                postParameterMd5);

            var signature = ComputeHmacSha256Lowercase(
                hmacData,
                credentials.ApiSecret);

            request.Headers.Remove("X-API-KEY");
            request.Headers.Remove("X-API-NONCE");
            request.Headers.Remove("X-API-SIGNATURE");

            request.Headers.Add("X-API-KEY", credentials.ApiKey);
            request.Headers.Add("X-API-NONCE", nonce.ToString(CultureInfo.InvariantCulture));
            request.Headers.Add("X-API-SIGNATURE", signature);
        }

        private long CreateNonce()
        {
            //var timestampNonce = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var timestampNonce = DateTime.Now.Ticks;

            while (true)
            {
                var previous = Interlocked.Read(ref _lastNonce);
                var next = Math.Max(timestampNonce, previous + 1);

                if (Interlocked.CompareExchange(ref _lastNonce, next, previous) == previous)
                    return next;
            }
        }

        private static async Task<string> GetNormalizedPostParameterStringAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Content == null)
                return string.Empty;

            if (request.Method != HttpMethod.Post &&
                request.Method != HttpMethod.Put &&
                request.Method != HttpMethod.Patch)
            {
                return string.Empty;
            }

            var content = await request.Content.ReadAsStringAsync(cancellationToken);

            if (string.IsNullOrWhiteSpace(content))
                return string.Empty;

            var pairs = content
                .Split('&', StringSplitOptions.RemoveEmptyEntries)
                .Select(part =>
                {
                    var index = part.IndexOf('=');

                    if (index < 0)
                    {
                        return new KeyValuePair<string, string>(
                            WebUtility.UrlDecode(part),
                            string.Empty);
                    }

                    var key = WebUtility.UrlDecode(part[..index]);
                    var value = WebUtility.UrlDecode(part[(index + 1)..]);

                    return new KeyValuePair<string, string>(key, value);
                })
                .OrderBy(x => x.Key, StringComparer.Ordinal)
                .ToArray();

            return string.Join(
                "&",
                pairs.Select(x =>
                    $"{UrlEncode(x.Key)}={UrlEncode(x.Value)}"));
        }

        private static string ComputeMd5Lowercase(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            var hash = MD5.HashData(bytes);

            return Convert.ToHexString(hash).ToLowerInvariant();
        }

        private static string ComputeHmacSha256Lowercase(
            string value,
            string secret)
        {
            var keyBytes = Encoding.UTF8.GetBytes(secret);
            var valueBytes = Encoding.UTF8.GetBytes(value);

            using var hmac = new HMACSHA256(keyBytes);

            return Convert
                .ToHexString(hmac.ComputeHash(valueBytes))
                .ToLowerInvariant();
        }

        private static string UrlEncode(string value)
        {
            return WebUtility.UrlEncode(value) ?? string.Empty;
        }

    }
}
