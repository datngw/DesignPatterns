using DesignPatterns.Creational.FactoryMethod;

Console.WriteLine("=== Creational Design Patterns ===\n");

Console.WriteLine("Patterns available:");
Console.WriteLine("  1. FactoryMethod");

Console.Write("\nSelect a pattern to run: ");
var choice = Console.ReadLine();

// TODO: Uncomment and implement as you go:
switch (choice)
{
    case "1": FactoryMethod.Run(); break;
    default: Console.WriteLine("Invalid choice. Please select a valid pattern."); break;
}
