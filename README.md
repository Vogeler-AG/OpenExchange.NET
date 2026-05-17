# OpenExchange.NET

Reusable .NET framework for interoperable exchange connectivity and standardized API integration.

---

# Overview

OpenExchange.NET is an open and modular framework for integrating financial exchanges and market platforms through a unified API abstraction layer.

The project focuses on:

- Interoperable exchange connectivity
- Standardized API integration
- Reusable authentication and signing infrastructure
- Unified market data models
- Extensible provider architecture
- Resilient HTTP communication patterns

OpenExchange.NET is designed to simplify the integration of heterogeneous exchange and market APIs in modern .NET applications.

---

# Motivation

Exchange and market APIs are highly fragmented:

- Different authentication mechanisms
- Inconsistent request/response formats
- Diverging market data structures
- Exchange-specific error handling
- Different rate limit and retry requirements

This fragmentation creates unnecessary complexity for developers building interoperable financial applications.

OpenExchange.NET aims to provide a reusable and extensible infrastructure layer that standardizes access patterns while preserving provider-specific capabilities.

---

# Goals

## Core Objectives

- Provide a reusable exchange connectivity framework for .NET
- Normalize heterogeneous exchange APIs into unified abstractions
- Improve interoperability between providers
- Reduce integration complexity
- Offer reusable authentication and request-signing infrastructure
- Enable extensible provider implementations

---

# Architecture

```text
src/

OpenExchange.Core
    Interfaces
    Models
    Exceptions

OpenExchange.Http
    HTTP pipeline
    Retry handling
    Rate limiting

OpenExchange.Security
    Request signing
    Nonce generation
    Authentication abstractions

OpenExchange.BitcoinDe
    bitcoin.de provider implementation

tests/
samples/
docs/
```

---

# Core Concepts

## Unified Exchange Abstraction

```csharp
public interface IExchangeClient
{
    Task<Ticker> GetTickerAsync(string symbol);

    Task<OrderBook> GetOrderBookAsync(string symbol);

    Task<IEnumerable<Trade>> GetTradesAsync(string symbol);
}
```

---

## Provider-Based Architecture

Each exchange implementation is encapsulated in its own provider package.

Example:

```text
OpenExchange.BitcoinDe
OpenExchange.Kraken
OpenExchange.Binance
```

This architecture enables:

- Independent provider implementations
- Shared core infrastructure
- Consistent integration patterns
- Extensible ecosystem support

---

# Security & Authentication

OpenExchange.NET includes reusable infrastructure for:

- HMAC request signing
- Nonce generation
- Replay protection
- Request authentication
- Retry and backoff handling
- Rate limit management

The goal is to provide a reusable and provider-agnostic security abstraction layer.

---

# Standards & Interoperability

The framework is designed around established internet and API standards, including:

- HTTP / REST
- JSON-based APIs
- OpenAPI-compatible design concepts
- HMAC authentication patterns
- OAuth2/OpenID integration concepts

OpenExchange.NET aims to improve interoperability and reusability across heterogeneous exchange APIs.

---

# Current Status

## Implemented

- Core abstraction interfaces
- Shared market data models
- bitcoin.de provider integration
- HMAC signing infrastructure
- Nonce handling
- Basic retry and rate limit handling

## Planned

- Additional provider implementations
- WebSocket connectivity
- Unified order management abstractions
- Improved resiliency infrastructure
- OpenAPI schema support
- Mock/testing infrastructure
- Extended diagnostics and telemetry

---

# Roadmap

## Phase 1
- Stable core interfaces
- bitcoin.de provider
- Shared DTO models
- Security abstractions

## Phase 2
- Additional exchange providers
- WebSocket support
- Enhanced resiliency handling
- Extended diagnostics

## Phase 3
- Provider capability discovery
- Unified order abstractions
- Community provider ecosystem
- Extended interoperability tooling

---

# Quick Start

```csharp
            ICredentialProvider cred= new EnvironmentCredentialProvider("BitcoinDeApiKey","BitcoinDeApiSecret");
            IExchangeClient client = new BitcoinDeClient(cred);
            Ticker ticker=await client.GetTickerAsync("btceur");
            Console.WriteLine($"BTC/EUR Last Price: {ticker.Last}");
```

See:

```text
samples/BasicConsoleSample
```

---


# Why Open Source?

Reliable financial infrastructure benefits from:

- Transparency
- Reusability
- Community review
- Extensibility
- Interoperability

OpenExchange.NET is intended to become a reusable foundation for interoperable exchange connectivity in the .NET ecosystem.

---

# Contributing

Contributions and interoperability discussions are welcome.

Areas of interest include:

- Provider implementations
- Security/authentication
- API normalization
- Resiliency engineering
- Financial interoperability

---

# License

Licensed under the Apache License 2.0.

---

# Disclaimer

OpenExchange.NET is infrastructure software.

It does not provide financial advice, trading strategies, or investment recommendations.

Never commit API keys or secrets to source control.
Use environment variables, user secrets, or a secure secret store.