# OpenExchange.NET Roadmap

This document outlines the current direction and planned evolution of OpenExchange.NET.

The primary goal of the project is to provide reusable and interoperable infrastructure for standardized exchange and market API connectivity in the .NET ecosystem.

---

# Vision

OpenExchange.NET aims to become a modular and extensible framework for integrating heterogeneous exchange and market APIs through unified abstractions and reusable infrastructure components.

The project focuses on:

- Interoperability
- Standardized API integration
- Security abstractions
- Resilient communication patterns
- Extensible provider architecture

---

# Guiding Principles

The roadmap is guided by the following principles:

- Provider independence
- Minimal coupling
- Reusable infrastructure
- Security-first design
- Extensibility
- Incremental evolution

---

# Phase 1 — Foundation

## Core Infrastructure

- [ ] Establish stable core abstractions
- [ ] Define provider-independent market data models
- [ ] Implement shared exception hierarchy
- [ ] Create reusable HTTP pipeline foundation

---

## Security Infrastructure

- [ ] HMAC signing abstractions
- [ ] Nonce generation infrastructure
- [ ] Replay protection mechanisms
- [ ] Authentication abstraction layer

---

## Initial Provider Support

- [ ] bitcoin.de provider integration
- [ ] Shared DTO mapping infrastructure
- [ ] Basic market data access
- [ ] Initial order book support

---

## Documentation

- [ ] Initial architecture documentation
- [ ] Provider development guidelines
- [ ] Security documentation
- [ ] Sample applications

---

# Phase 2 — Interoperability & Resiliency

## Provider Expansion

- [ ] Kraken provider
- [ ] Binance provider
- [ ] Additional provider integrations

---

## HTTP & Resiliency

- [ ] Retry strategies
- [ ] Rate limit handling
- [ ] Backoff policies
- [ ] Resilient request pipeline

---

## Streaming & Realtime

- [ ] WebSocket abstraction layer
- [ ] Streaming market data support
- [ ] Connection lifecycle handling
- [ ] Reconnect strategies

---

## Diagnostics

- [ ] Structured logging
- [ ] Telemetry hooks
- [ ] Request tracing
- [ ] Metrics infrastructure

---

# Phase 3 — Unified Exchange Abstractions

## Trading Abstractions

- [ ] Unified order abstractions
- [ ] Capability discovery
- [ ] Shared account abstractions
- [ ] Position and balance models

---

## Standardization Improvements

- [ ] Improved API normalization
- [ ] Unified error models
- [ ] OpenAPI integration concepts
- [ ] Consistent provider capability metadata

---

## Ecosystem Support

- [ ] Community provider model
- [ ] Provider extension SDK
- [ ] Additional samples and templates
- [ ] Expanded testing infrastructure

---

# Long-Term Ideas

Potential future topics include:

- FIX protocol integration
- OAuth/OpenID-based provider integrations
- Pluggable serialization strategies
- Multi-provider aggregation
- Historical market data abstraction
- Unified event model
- Sandboxed provider testing environment

---

# Non-Goals

The following areas are intentionally outside the scope of OpenExchange.NET:

- Trading strategies
- Automated trading bots
- Investment recommendations
- Financial advice
- Proprietary exchange logic

OpenExchange.NET focuses exclusively on reusable infrastructure and interoperability.

---

# Contributions & Feedback

Roadmap discussions, interoperability ideas, and provider proposals are welcome.

The project intentionally evolves incrementally to maintain stability and architectural consistency.