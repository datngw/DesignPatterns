namespace DesignPatterns.Behavioral.Observer;

/// <summary>
/// Observer Pattern
///
/// Intent: Define a one-to-many dependency between objects so that when one object changes state,
/// all its dependents are notified and updated automatically.
///
/// When to use:
///   - When a change to one object requires changing others, and you don't know how many need to change
///   - When an object should be able to notify others without being tightly coupled to them
///
/// Real-world analogy: YouTube subscriptions — when a channel uploads a video,
/// all subscribers get notified.
/// </summary>

// TODO: Implement Observer
// 1. Subject interface with Attach(), Detach(), Notify()
// 2. Concrete subject maintaining state and notifying observers
// 3. Observer interface with Update()
// 4. Concrete observers reacting to state changes
