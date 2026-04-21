namespace DesignPatterns.Structural.Proxy;

/// <summary>
/// Proxy Pattern
///
/// Intent: Provide a surrogate or placeholder for another object to control access to it.
///
/// When to use:
///   - Virtual proxy: lazy-load expensive objects
///   - Protection proxy: control access based on permissions
///   - Remote proxy: represent an object in a different address space
///   - Smart proxy: add housekeeping logic (caching, reference counting)
///
/// Real-world analogy: A credit card is a proxy for a bank account —
/// it provides the same payment interface but adds security and tracking.
/// </summary>

// TODO: Implement Proxy
// 1. Subject interface (e.g., IResource)
// 2. Real subject class (the actual expensive/protected object)
// 3. Proxy class implementing Subject and controlling access to RealSubject
