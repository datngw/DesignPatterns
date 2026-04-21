# Singleton Pattern

## What Is It?

Singleton is a **creational design pattern** that ensures a class has **only one instance** and provides a **global point of access** to it. No matter how many times you request it, you always get the same object.

## The Coffee Shop Way

A coffee shop has one main **coffee machine** that handles all brewing orders. You don't fire up a new machine every time a customer walks in — everyone shares the same one. If two baristas try to get the machine, they get the exact same instance.

```
Barista A → GetInstance() → CoffeeMachine #1
Barista B → GetInstance() → CoffeeMachine #1  (same machine!)
```

## The Problem

Some resources should exist **once and only once** — a database connection, a configuration manager, a shared hardware device. Creating multiple instances causes inconsistent state, wasted memory, or conflicts.

## The Solution

Make the constructor **private** so nobody can call `new`. Provide a **static method** (`GetInstance()`) that creates the instance on the first call and returns that same instance on every subsequent call. Use a **lock** to make it thread-safe.

## Class Diagram

```
┌──────────────────────────────┐
│        CoffeeMachine         │
├──────────────────────────────┤
│ - _instance: CoffeeMachine   │
│ - _lock: object              │
│ + Name: string               │
│ + OrdersProcessed: int       │
├──────────────────────────────┤
│ - CoffeeMachine()            │  ← private constructor
│ + GetInstance(): CoffeeMachine│  ← static, thread-safe
│ + Brew(drink: string): void  │
└──────────────────────────────┘
          │
          │ always returns the same instance
          ▼
     ┌─────────┐
     │ Instance │  (one and only)
     └─────────┘
```

**How to read it:** `CoffeeMachine` hides its constructor and exposes `GetInstance()`. The first call creates the instance; every call after returns it. External code can never create a second one.

## Structure

| Role | Coffee Shop | Code |
|------|-------------|------|
| **Singleton** | The one coffee machine | `CoffeeMachine` sealed class |
| **Static Instance** | The single running machine | `_instance` static field |
| **Global Access** | Anyone can use the machine | `GetInstance()` static method |
| **Thread-safe Lock** | No two baristas start it at once | `_lock` + double-check pattern |

## When to Use

- A class must have exactly one instance shared across the entire application
- You need a single shared resource (database, config, logger, hardware)
- You want to avoid global variables but still need global access

## Key Idea

> **One instance, globally accessible.** Seal the class, hide the constructor, and gate access through a static method that always returns the same object.
