using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Security.Credentials
{
    public class EnvironmentCredentialProvider : ICredentialProvider
    {
        private readonly string _apiKeyVariable;
        private readonly string _apiSecretVariable;

        public EnvironmentCredentialProvider(
            string apiKeyVariable,
            string apiSecretVariable)
        {
            _apiKeyVariable = apiKeyVariable;
            _apiSecretVariable = apiSecretVariable;
        }

        public ApiCredentials GetCredentials()
        {
            var apiKey = Environment.GetEnvironmentVariable(_apiKeyVariable);
            var apiSecret = Environment.GetEnvironmentVariable(_apiSecretVariable);

            return new ApiCredentials(apiKey ?? string.Empty, apiSecret ?? string.Empty);
        }
    }
}
