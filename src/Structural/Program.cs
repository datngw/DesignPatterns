using DesignPatterns.Structural.Adapter;

Console.WriteLine("=== Structural Design Patterns ===\n");

Console.WriteLine("Patterns available:");
Console.WriteLine("  1. Adapter");
Console.WriteLine("  2. Bridge");
Console.WriteLine("  3. Composite");
Console.WriteLine("  4. Decorator");
Console.WriteLine("  5. Facade");
Console.WriteLine("  6. Flyweight");
Console.WriteLine("  7. Proxy");

Console.Write("\nSelect a pattern to run: ");
var choice = Console.ReadLine();

switch (choice)
{
    case "1": Adapter.Run(); break;
    case "2": Console.WriteLine("Bridge is not implemented yet."); break;
    case "3": Console.WriteLine("Composite is not implemented yet."); break;
    case "4": Console.WriteLine("Decorator is not implemented yet."); break;
    case "5": Console.WriteLine("Facade is not implemented yet."); break;
    case "6": Console.WriteLine("Flyweight is not implemented yet."); break;
    case "7": Console.WriteLine("Proxy is not implemented yet."); break;
    default: Console.WriteLine("Invalid selection."); break;
}
