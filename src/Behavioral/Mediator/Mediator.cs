namespace DesignPatterns.Behavioral.Mediator;

/// <summary>
/// Mediator Pattern
///
/// Intent: Define an object that encapsulates how a set of objects interact.
/// Mediator promotes loose coupling by keeping objects from referring to each other explicitly.
///
/// When to use:
///   - When a set of objects communicate in complex but well-defined ways
///   - When reusing an object is difficult because it refers to many other objects
///   - When a behavior that's distributed between several classes should be customizable
///
/// Real-world analogy: An air traffic control tower — pilots don't talk to each other
/// directly; all communication goes through the tower.
/// </summary>

// TODO: Implement Mediator
// 1. Mediator interface with Notify() method
// 2. Concrete mediator coordinating colleague objects
// 3. Colleague base class with a reference to the mediator
// 4. Concrete colleagues (e.g., Button, TextField, Checkbox)
