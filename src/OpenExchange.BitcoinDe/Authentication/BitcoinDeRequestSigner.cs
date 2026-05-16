using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OpenExchange.BitcoinDe.Authentication
{
    public class BitcoinDeRequestSigner
    {
        private readonly string _apiSecret;

        public BitcoinDeRequestSigner(string apiSecret)
        {
            _apiSecret = apiSecret;
        }

        public void Sign(HttpRequestMessage request)
        {
            var payload = request.RequestUri?.ToString() ?? string.Empty;

            using var hmac = new HMACSHA256(
                Encoding.UTF8.GetBytes(_apiSecret));

            var hash = hmac.ComputeHash(
                Encoding.UTF8.GetBytes(payload));

            var signature = Convert.ToHexString(hash);

            request.Headers.Add(
                "X-Signature",
                signature);
        }
    }
}
