namespace DesignPatterns.Behavioral.Iterator;

/// <summary>
/// Iterator Pattern
///
/// Intent: Provide a way to access the elements of an aggregate object sequentially
/// without exposing its underlying representation.
///
/// When to use:
///   - When you want to access an aggregate object's contents without exposing its internal structure
///   - When you want to support multiple traversals of aggregate objects
///   - When you want to provide a uniform interface for traversing different aggregate structures
///
/// Real-world analogy: A TV remote's "next channel" button — you cycle through
/// channels one at a time without knowing how they're stored internally.
/// </summary>

// TODO: Implement Iterator
// 1. Iterator interface with MoveNext(), Current(), Reset()
// 2. Aggregate interface with CreateIterator()
// 3. Concrete aggregate (collection)
// 4. Concrete iterator traversing the collection
