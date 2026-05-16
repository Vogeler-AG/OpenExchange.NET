# OpenExchange.NET Roadmap

This document outlines the planned direction and incremental evolution of OpenExchange.NET.

The primary goal of the project is to provide reusable and interoperable infrastructure for standardized exchange and market API connectivity in the .NET ecosystem.

---

# Vision

OpenExchange.NET aims to become a modular and extensible framework for integrating heterogeneous exchange and market APIs through unified abstractions and reusable infrastructure components.

The project focuses on:

- Interoperability
- Standardized API integration
- Provider-independent abstractions
- Security infrastructure
- Resilient communication patterns
- Extensible provider architecture

---

# Guiding Principles

The roadmap is guided by the following principles:

- Incremental evolution
- Stable abstractions
- Minimal provider coupling
- Reusable infrastructure
- Security-first design
- Extensibility
- Maintainability

---

# Phase 1 — Foundation

## Core Infrastructure

- [ ] Establish stable core interfaces
- [ ] Define shared exchange-independent models
- [ ] Create common exception hierarchy
- [ ] Define provider abstraction contracts
- [ ] Create reusable HTTP infrastructure foundation

---

## Security Infrastructure

- [ ] HMAC signing abstractions
- [ ] Nonce generation infrastructure
- [ ] Authentication abstraction layer
- [ ] Replay protection concepts
- [ ] Shared signing utilities

---

## Initial Provider Support

- [ ] bitcoin.de provider implementation
- [ ] Basic market data access
- [ ] Shared DTO mapping infrastructure
- [ ] Initial order book support

---

## Documentation

- [ ] Architecture documentation
- [ ] Provider development guidelines
- [ ] Security documentation
- [ ] Sample integrations

---

# Phase 2 — Resiliency & Interoperability

## HTTP & Communication

- [ ] Retry strategies
- [ ] Rate limit handling
- [ ] Backoff policies
- [ ] Centralized request pipeline
- [ ] Improved resiliency abstractions

---

## Additional Providers

- [ ] Kraken provider
- [ ] Binance provider
- [ ] Additional provider integrations

---

## Streaming & Realtime Support

- [ ] WebSocket abstraction layer
- [ ] Streaming market data support
- [ ] Connection lifecycle management
- [ ] Reconnect handling

---

## Diagnostics

- [ ] Structured logging
- [ ] Telemetry hooks
- [ ] Metrics infrastructure
- [ ] Request tracing support

---

# Phase 3 — Unified Exchange Abstractions

## Trading Infrastructure

- [ ] Unified order abstractions
- [ ] Shared account models
- [ ] Balance abstractions
- [ ] Position abstractions
- [ ] Provider capability discovery

---

## API Standardization

- [ ] Unified error models
- [ ] Improved API normalization
- [ ] Consistent provider metadata
- [ ] OpenAPI integration concepts

---

## Ecosystem Expansion

- [ ] Provider extension SDK
- [ ] Community provider model
- [ ] Expanded testing infrastructure
- [ ] Additional samples and templates

---

# Long-Term Ideas

Potential future areas include:

- FIX protocol integration
- OAuth/OpenID provider integrations
- Multi-provider aggregation
- Historical market data abstraction
- Unified event model
- Sandboxed provider testing
- Advanced resiliency tooling

---

# Non-Goals

The following areas are intentionally outside the scope of OpenExchange.NET:

- Trading strategies
- Automated trading bots
- Investment recommendations
- Financial advice
- Proprietary exchange logic
- Portfolio optimization systems

OpenExchange.NET focuses exclusively on reusable infrastructure and interoperability.

---

# Community & Contributions

The roadmap intentionally evolves incrementally to preserve stability and architectural consistency.

Feedback, interoperability discussions, and provider proposals are welcome.