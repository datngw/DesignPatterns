namespace DesignPatterns.Behavioral.Visitor;

/// <summary>
/// Visitor Pattern
///
/// Intent: Represent an operation to be performed on the elements of an object structure.
/// Visitor lets you define a new operation without changing the classes of the elements on which it operates.
///
/// When to use:
///   - When an object structure contains many classes with differing interfaces and you want to
///     perform operations on them that depend on their concrete classes
///   - When many distinct and unrelated operations are needed on objects in a structure
///   - When the classes defining the object structure rarely change, but you often define new operations
///
/// Real-world analogy: An insurance agent visiting different types of buildings
/// (house, bank, restaurant) — the agent offers different policies depending on the building type.
/// </summary>

// TODO: Implement Visitor
// 1. Visitor interface with Visit() methods for each element type
// 2. Concrete visitors implementing specific operations
// 3. Element interface with Accept(IVisitor) method (double dispatch)
// 4. Concrete elements implementing Accept()
// 5. Object structure (collection of elements) that can be traversed
