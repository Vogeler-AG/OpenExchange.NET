using System;
using System.Collections.Generic;
using System.Text;
using OpenExchange.Core.Interfaces;

namespace OpenExchange.Security.Http
{
    /// <summary>
    /// Delegating handler that signs outgoing HTTP requests using an
    /// <see cref="IRequestSigner"/> before sending them to the inner handler.
    /// </summary>
    public class SigningHandler : DelegatingHandler
    {
        private readonly IRequestSigner _requestSigner;

        public SigningHandler(IRequestSigner requestSigner)
        {
            _requestSigner = requestSigner;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await _requestSigner.SignAsync(request, cancellationToken);
            HttpResponseMessage result = await base.SendAsync(request, cancellationToken);
            return result;
        }
    }
}
