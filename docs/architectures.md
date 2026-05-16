# OpenExchange.NET Architecture

This document describes the high-level architecture and design principles of OpenExchange.NET.

The project is designed as a modular and extensible framework for interoperable exchange and market API connectivity in .NET applications.

---

# Architectural Goals

The architecture is designed around the following goals:

- Provider-independent abstractions
- Reusable infrastructure components
- Interoperable API access
- Extensible provider model
- Clear separation of concerns
- Security-first design
- Incremental extensibility

---

# High-Level Architecture

```text
Application Layer
        │
        ▼
OpenExchange.Core
        │
        ├── OpenExchange.Security
        │
        ├── OpenExchange.Http
        │
        ▼
Provider Implementations
(OpenExchange.BitcoinDe, etc.)
        │
        ▼
External Exchange APIs
```

---

# Core Components

## OpenExchange.Core

The Core project contains provider-independent abstractions and shared models.

Responsibilities include:

- Common interfaces
- Shared DTO models
- Exception hierarchy
- Provider abstractions
- Exchange-independent contracts

Example interfaces:

```csharp
IExchangeClient
IMarketDataProvider
ITradingProvider
```

The Core layer must not contain provider-specific implementations.

---

## OpenExchange.Security

The Security project provides reusable authentication and request signing infrastructure.

Responsibilities include:

- HMAC signing
- Nonce generation
- Authentication abstractions
- Replay protection concepts
- Provider-agnostic signing interfaces

The goal is to isolate security-related infrastructure from provider implementations.

---

## OpenExchange.Http

The HTTP layer contains reusable communication infrastructure.

Responsibilities include:

- HTTP pipeline handling
- Retry policies
- Rate limit handling
- Backoff strategies
- Shared HTTP utilities

This layer is intended to centralize resilient communication behavior.

---

## Provider Implementations

Provider projects encapsulate exchange-specific behavior.

Examples:

```text
OpenExchange.BitcoinDe
OpenExchange.Kraken
OpenExchange.Binance
```

Responsibilities include:

- API endpoint integration
- Provider-specific DTOs
- Mapping logic
- Authentication integration
- Exchange-specific behavior

Provider projects should remain isolated from each other.

---

# Provider Model

Each provider implementation follows the same conceptual structure:

```text
Provider
├── Clients
├── DTOs
├── Mapping
├── Authentication
└── Endpoints
```

This structure allows providers to evolve independently while sharing common infrastructure.

---

# Data Flow

Typical request flow:

```text
Application
    │
    ▼
Provider-Independent Interface
    │
    ▼
Provider Implementation
    │
    ▼
Security / Signing
    │
    ▼
HTTP Pipeline
    │
    ▼
External Exchange API
```

Response flow:

```text
Exchange Response
    │
    ▼
Provider DTOs
    │
    ▼
Mapping Layer
    │
    ▼
Unified OpenExchange Models
    │
    ▼
Application
```

---

# Model Normalization

A key architectural goal is the normalization of heterogeneous exchange APIs into unified models.

Example:

```text
Provider-Specific DTO
        ▼
Mapping Layer
        ▼
Unified OpenExchange Model
```

This enables:

- Provider interchangeability
- Reduced application complexity
- Shared business integrations
- Improved interoperability

---

# Dependency Direction

Dependencies should flow inward toward abstractions.

```text
Providers
    ▼
Core
```

Rules:

- Core must remain provider-independent
- Providers may depend on Core and Security
- Providers should not depend on other providers
- Shared abstractions belong in Core

---

# Security Considerations

Security is treated as a first-class architectural concern.

Key principles include:

- Isolation of signing logic
- Avoidance of credential leakage
- Reusable authentication infrastructure
- Explicit request authentication
- Centralized security abstractions

---

# Extensibility

The architecture is intentionally modular to support:

- Additional exchange providers
- Alternative authentication methods
- Streaming/WebSocket integrations
- Extended resiliency infrastructure
- Community-driven provider ecosystem

---

# Non-Goals

The architecture intentionally excludes:

- Trading strategies
- Automated trading systems
- Investment logic
- Proprietary exchange optimizations

OpenExchange.NET focuses exclusively on reusable infrastructure and interoperability.