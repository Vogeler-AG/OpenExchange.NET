using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    public interface IAuthenticationProvider
    {
        Task AuthenticateAsync(HttpRequestMessage request, CancellationToken  cancellationToken);
    }
}
