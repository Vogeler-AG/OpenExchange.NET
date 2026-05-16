# Contributing to OpenExchange.NET

Thank you for your interest in contributing to OpenExchange.NET.

The goal of this project is to provide reusable and interoperable infrastructure for exchange and market API connectivity in the .NET ecosystem.

Contributions of all sizes are welcome.

---

# Areas of Interest

Contributions are especially welcome in the following areas:

- Exchange provider implementations
- API normalization
- Authentication and request signing
- Security and resiliency improvements
- Retry and rate limit handling
- WebSocket connectivity
- Documentation and examples
- Testing infrastructure
- Diagnostics and telemetry

---

# Project Principles

OpenExchange.NET follows a few core design principles:

- Provider-agnostic abstractions
- Clean separation of concerns
- Extensible architecture
- Reusable infrastructure components
- Interoperability-focused design
- Minimal provider coupling

Please try to preserve these principles when contributing.

---

# Development Setup

## Requirements

- .NET SDK 8.0 or later
- Visual Studio 2022 or JetBrains Rider

---

# Repository Structure

```text
src/
    OpenExchange.Core
    OpenExchange.Http
    OpenExchange.Security
    OpenExchange.BitcoinDe

tests/
samples/
docs/
```

---

# Contribution Workflow

## 1. Fork the repository

Create your own fork of the repository and clone it locally.

---

## 2. Create a feature branch

```bash
git checkout -b feature/my-feature
```

---

## 3. Implement changes

Please keep changes:

- Focused
- Well-structured
- Provider-independent where possible

---

## 4. Add or update tests

Where appropriate, include tests for new functionality.

---

## 5. Submit a Pull Request

Please provide:

- Clear description of the change
- Motivation and context
- Any relevant documentation updates

---

# Coding Guidelines

## General

- Prefer readability over cleverness
- Keep provider-specific logic isolated
- Avoid unnecessary dependencies
- Favor async APIs where appropriate
- Keep abstractions stable and minimal

---

## Naming

- Use clear and descriptive names
- Use consistent OpenExchange.* naming conventions

Example:

```text
OpenExchange.Core
OpenExchange.Security
OpenExchange.BitcoinDe
```

---

# Security

Security-related contributions are highly appreciated.

Please avoid publishing sensitive information such as:

- API keys
- Secrets
- Internal endpoints
- Credentials

If you discover a security issue, please report it responsibly before opening a public issue.

---

# Discussions & Ideas

Discussions around interoperability, provider abstractions, and API standardization are welcome.

Potential future topics include:

- Unified order abstractions
- Provider capability discovery
- OpenAPI integration
- Streaming/WebSocket abstractions
- Standardized error models

---

# License

By contributing to OpenExchange.NET, you agree that your contributions will be licensed under the Apache License 2.0.