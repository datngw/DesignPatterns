Console.WriteLine("=== Behavioral Design Patterns ===\n");

Console.WriteLine("Patterns available:");
Console.WriteLine("  1. Chain of Responsibility");
Console.WriteLine("  2. Command");
Console.WriteLine("  3. Iterator");
Console.WriteLine("  4. Mediator");
Console.WriteLine("  5. Memento");
Console.WriteLine("  6. Observer");
Console.WriteLine("  7. State");
Console.WriteLine("  8. Strategy");
Console.WriteLine("  9. Template Method");
Console.WriteLine("  10. Visitor");

Console.Write("\nSelect a pattern to run: ");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":  Console.WriteLine("Chain of Responsibility is not implemented yet."); break;
    case "2":  Console.WriteLine("Command is not implemented yet."); break;
    case "3":  Console.WriteLine("Iterator is not implemented yet."); break;
    case "4":  Console.WriteLine("Mediator is not implemented yet."); break;
    case "5":  Console.WriteLine("Memento is not implemented yet."); break;
    case "6":  Console.WriteLine("Observer is not implemented yet."); break;
    case "7":  Console.WriteLine("State is not implemented yet."); break;
    case "8":  Console.WriteLine("Strategy is not implemented yet."); break;
    case "9":  Console.WriteLine("Template Method is not implemented yet."); break;
    case "10": Console.WriteLine("Visitor is not implemented yet."); break;
    default:   Console.WriteLine("Invalid selection."); break;
}
