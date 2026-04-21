namespace DesignPatterns.Behavioral.TemplateMethod;

/// <summary>
/// Template Method Pattern
///
/// Intent: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
/// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
///
/// When to use:
///   - When you want to implement the invariant parts of an algorithm once and leave subclasses to implement behavior
///   - When common behavior among subclasses should be factored and localized in a common class
///
/// Real-world analogy: A recipe — the steps are fixed (prep, cook, serve),
/// but the specific ingredients/techniques vary by dish.
/// </summary>

// TODO: Implement Template Method
// 1. Abstract class with a template method (defines algorithm steps)
// 2. Abstract methods for steps that subclasses must implement
// 3. Concrete subclasses implementing the specific steps
// 4. Optional: hook methods that subclasses can optionally override
