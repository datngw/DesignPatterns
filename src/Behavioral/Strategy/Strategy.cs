namespace DesignPatterns.Behavioral.Strategy;

/// <summary>
/// Strategy Pattern
///
/// Intent: Define a family of algorithms, encapsulate each one, and make them interchangeable.
/// Strategy lets the algorithm vary independently from clients that use it.
///
/// When to use:
///   - When many related classes differ only in their behavior
///   - When you need different variants of an algorithm
///   - When an algorithm uses data that clients shouldn't know about
///   - To avoid complex conditional statements for selecting behavior
///
/// Real-world analogy: A navigation app — you can choose driving, walking, or cycling
/// route strategy. Each uses the same destination but different algorithms.
/// </summary>

// TODO: Implement Strategy
// 1. Strategy interface (e.g., IRouteStrategy)
// 2. Concrete strategies (e.g., DrivingStrategy, WalkingStrategy)
// 3. Context class that holds a strategy reference and delegates to it
