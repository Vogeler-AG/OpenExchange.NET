using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    public interface IRequestSigner
    {
        Task SignAsync(HttpRequestMessage request, CancellationToken cancellationToken = default);
    }
}
