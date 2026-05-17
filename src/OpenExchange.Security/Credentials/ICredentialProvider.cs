using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Security.Credentials
{
    public interface ICredentialProvider
    {
        ApiCredentials GetCredentials();
    }
}

