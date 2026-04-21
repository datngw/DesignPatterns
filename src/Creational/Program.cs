using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;

Console.WriteLine("=== Creational Design Patterns ===\n");

Console.WriteLine("Patterns available:");
Console.WriteLine("  1. FactoryMethod");
Console.WriteLine("  2. AbstractFactory");
Console.WriteLine("  3. Builder");
Console.WriteLine("  4. Prototype");
Console.WriteLine("  5. Singleton");

Console.Write("\nSelect a pattern to run: ");
var choice = Console.ReadLine();

switch (choice)
{
    case "1": FactoryMethod.Run(); break;
    case "2": Console.WriteLine("AbstractFactory is not implemented yet."); break;
    case "3": Builder.Run(); break;
    case "4": Console.WriteLine("Prototype is not implemented yet."); break;
    case "5": Singleton.Run(); break;
    default: Console.WriteLine("Invalid selection."); break;
}
