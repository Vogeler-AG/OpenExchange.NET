using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    public interface IRequestSigner
    {
        void Sign(HttpRequestMessage request);
    }
}
