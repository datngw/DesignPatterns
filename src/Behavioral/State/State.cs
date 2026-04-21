namespace DesignPatterns.Behavioral.State;

/// <summary>
/// State Pattern
///
/// Intent: Allow an object to alter its behavior when its internal state changes.
/// The object will appear to change its class.
///
/// When to use:
///   - When an object's behavior depends on its state, and it must change its behavior at run-time
///   - When operations have large, multi-part conditional statements that depend on the object's state
///
/// Real-world analogy: A vending machine — it behaves differently depending on whether
/// you've inserted coins, selected a product, or it's out of stock.
/// </summary>

// TODO: Implement State
// 1. State interface with action methods
// 2. Concrete states (e.g., IdleState, HasCoinState, SoldState)
// 3. Context class that holds a reference to the current state
// 4. State transitions happen within concrete states
