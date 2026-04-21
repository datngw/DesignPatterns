namespace DesignPatterns.Structural.Composite;

/// <summary>
/// Composite Pattern
///
/// Intent: Compose objects into tree structures to represent part-whole hierarchies.
/// Composite lets clients treat individual objects and compositions of objects uniformly.
///
/// When to use:
///   - When you want to represent a part-whole hierarchy
///   - When you want clients to be able to ignore the difference between compositions
///     of objects and individual objects
///
/// Real-world analogy: A file system — files and folders are both treated as "items",
/// but a folder can contain other items.
/// </summary>

// TODO: Implement Composite
// 1. Component interface (e.g., IFileSystemItem)
// 2. Leaf class (e.g., File) — no children
// 3. Composite class (e.g., Folder) — can contain children
// 4. Client treats both leaves and composites uniformly
