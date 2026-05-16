# Provider Architecture

This document describes the provider model used by OpenExchange.NET.

Providers encapsulate exchange-specific integrations while exposing unified and provider-independent abstractions through the OpenExchange.Core layer.

The provider architecture is designed to support interoperability, modularity, and incremental extensibility.

---

# Goals

The provider model is designed around the following goals:

- Isolate provider-specific behavior
- Enable reusable infrastructure components
- Normalize heterogeneous APIs
- Reduce coupling between integrations
- Allow incremental provider expansion
- Simplify application-level integration

---

# Provider Overview

Each exchange or market platform integration is implemented as an independent provider package.

Examples:

```text
OpenExchange.BitcoinDe
OpenExchange.Kraken
OpenExchange.Binance
```

Providers expose standardized interfaces while internally handling exchange-specific behavior.

---

# Provider Responsibilities

A provider implementation is responsible for:

- API endpoint communication
- Provider-specific DTO handling
- Authentication integration
- Request signing integration
- Mapping provider models to unified OpenExchange models
- Exchange-specific error handling

---

# Provider Structure

A provider project typically follows this structure:

```text
OpenExchange.ProviderName/

├── Clients/
├── DTOs/
├── Mapping/
├── Authentication/
├── Endpoints/
└── Exceptions/
```

---

# Clients

The Clients layer contains the main exchange integration implementation.

Example:

```csharp
public sealed class BitcoinDeClient : IExchangeClient
{
}
```

Clients expose provider-independent interfaces defined in OpenExchange.Core.

---

# DTOs

DTOs represent provider-specific request and response structures.

Example:

```text
BitcoinDeTickerResponse
KrakenOrderBookResponse
```

DTOs should remain isolated within the provider implementation.

Provider DTOs should never leak into the shared Core abstraction layer.

---

# Mapping Layer

The Mapping layer converts provider-specific DTOs into unified OpenExchange models.

Example:

```text
Provider DTO
    ▼
Mapping Layer
    ▼
OpenExchange Model
```

This normalization layer is critical for interoperability.

---

# Authentication

Authentication implementations integrate provider-specific authentication requirements into the shared security infrastructure.

Examples include:

- HMAC signing
- Nonce generation
- API key authentication
- OAuth-based flows

Authentication implementations should reuse abstractions from OpenExchange.Security whenever possible.

---

# Endpoints

The Endpoints layer centralizes provider-specific API endpoint definitions.

Example:

```text
/api/v1/orderbook
/api/v1/trades
/api/v1/account
```

Keeping endpoint definitions centralized improves maintainability and discoverability.

---

# Error Handling

Providers should translate exchange-specific errors into shared OpenExchange exception types whenever appropriate.

Example:

```text
Provider Error
    ▼
Mapping
    ▼
Shared OpenExchange Exception
```

This reduces application-level provider coupling.

---

# Provider Isolation

Providers should remain isolated from each other.

Rules:

- Providers must not reference other providers
- Shared abstractions belong in OpenExchange.Core
- Shared infrastructure belongs in Security or Http
- Provider-specific logic stays inside the provider project

---

# Dependency Model

Typical dependency direction:

```text
Provider
    ▼
Core
    ▼
Security / Http
```

The Core project must remain provider-independent.

---

# Future Expansion

The provider architecture is intentionally designed for incremental expansion.

Potential future provider categories include:

- Cryptocurrency exchanges
- Financial trading platforms
- Market data providers
- Broker APIs
- FIX-based systems

---

# Design Principles

Providers should strive for:

- Minimal coupling
- Explicit behavior
- Stable abstractions
- Predictable error handling
- Consistent naming
- Reusable infrastructure integration

---

# Non-Goals

Providers should not contain:

- Trading strategies
- Automated trading logic
- Portfolio optimization logic
- Investment recommendations
- Proprietary application behavior

The provider model focuses exclusively on interoperability and reusable infrastructure.