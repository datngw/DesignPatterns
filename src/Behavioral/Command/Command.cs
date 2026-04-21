namespace DesignPatterns.Behavioral.Command;

/// <summary>
/// Command Pattern
///
/// Intent: Encapsulate a request as an object, thereby letting you parameterize clients
/// with different requests, queue or log requests, and support undoable operations.
///
/// When to use:
///   - When you need to parameterize objects by an action to perform
///   - When you want to support undo/redo
///   - When you want to queue, schedule, or log operations
///
/// Real-world analogy: A restaurant order (command) — the customer writes it,
/// the waiter carries it, the chef executes it.
/// </summary>

// TODO: Implement Command
// 1. Command interface with Execute() and Undo()
// 2. Concrete commands wrapping a receiver
// 3. Receiver class that does the actual work
// 4. Invoker class that triggers commands
