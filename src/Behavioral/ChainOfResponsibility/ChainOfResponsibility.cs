namespace DesignPatterns.Behavioral.ChainOfResponsibility;

/// <summary>
/// Chain of Responsibility Pattern
///
/// Intent: Avoid coupling the sender of a request to its receiver by giving more than
/// one object a chance to handle the request. Chain the receiving objects and pass the
/// request along the chain until an object handles it.
///
/// When to use:
///   - When more than one object may handle a request, and the handler isn't known a priori
///   - When you want to issue a request to one of several objects without specifying the receiver explicitly
///
/// Real-world analogy: Tech support — Level 1 → Level 2 → Level 3 engineer,
/// the request escalates until someone can handle it.
/// </summary>

// TODO: Implement Chain of Responsibility
// 1. Handler abstract class with SetNext() and HandleRequest()
// 2. Concrete handlers (e.g., Level1Support, Level2Support, Level3Support)
// 3. Client builds the chain and submits requests
