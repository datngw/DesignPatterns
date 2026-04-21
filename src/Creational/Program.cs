using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;

Console.WriteLine("=== Creational Design Patterns ===\n");

Console.WriteLine("Patterns available:");
Console.WriteLine("  1. FactoryMethod");
Console.WriteLine("  2. Singleton");

Console.Write("\nSelect a pattern to run: ");
var choice = Console.ReadLine();

switch (choice)
{
    case "1": FactoryMethod.Run(); break;
    case "2": Singleton.Run(); break;
    default: Console.WriteLine("Invalid choice. Please select a valid pattern."); break;
}
