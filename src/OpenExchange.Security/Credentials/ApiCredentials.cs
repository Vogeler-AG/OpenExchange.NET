using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Security.Credentials
{
    public class ApiCredentials
    {
        public string ApiKey { get; }
        public string ApiSecret { get; }

        public ApiCredentials(string apiKey, string apiSecret)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("API key must not be empty.", nameof(apiKey));

            if (string.IsNullOrWhiteSpace(apiSecret))
                throw new ArgumentException("API secret must not be empty.", nameof(apiSecret));

            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }
    }
}
