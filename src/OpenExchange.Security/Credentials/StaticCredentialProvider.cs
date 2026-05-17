using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Security.Credentials
{
    public class StaticCredentialProvider : ICredentialProvider
    {
        private readonly ApiCredentials _credentials;

        public StaticCredentialProvider(ApiCredentials credentials)
        {
            _credentials = credentials;
        }

        public ApiCredentials GetCredentials()
        {
            return _credentials;
        }
    }
}
