using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    /// <summary>
    /// Defines a component that can sign HTTP requests for authenticated API calls.
    /// Implementations are expected to add authentication headers or other
    /// required security information to the provided <see cref="HttpRequestMessage"/>.
    /// </summary>
    public interface IRequestSigner
    {
        /// <summary>
        /// Sign the specified HTTP request asynchronously.
        /// The implementation should modify the request by adding headers or
        /// other signature data required by the target API.
        /// </summary>
        /// <param name="request">The HTTP request to sign. Must not be null.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        Task SignAsync(HttpRequestMessage request, CancellationToken cancellationToken = default);
    }
}
