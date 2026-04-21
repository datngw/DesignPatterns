namespace DesignPatterns.Structural.Flyweight;

/// <summary>
/// Flyweight Pattern
///
/// Intent: Use sharing to support large numbers of fine-grained objects efficiently.
///
/// When to use:
///   - When an application uses a large number of objects
///   - When storage costs are high because of the sheer quantity of objects
///   - When most object state can be made extrinsic (shared)
///
/// Real-world analogy: A forest with millions of trees — each tree shares common
/// texture/mesh data (intrinsic state) and only stores its position (extrinsic state).
/// </summary>

// TODO: Implement Flyweight
// 1. Flyweight interface with an operation method accepting extrinsic state
// 2. Concrete flyweight storing intrinsic (shared) state
// 3. Flyweight factory that caches and reuses flyweights
// 4. Context class storing extrinsic (unique) state
