namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Singleton Pattern
///
/// Intent: Ensure a class has only one instance, and provide a global point of access to it.
///
/// When to use:
///   - When there must be exactly one instance of a class, made accessible to all clients
///   - When the sole instance should be extensible by subclassing
///
/// Real-world analogy: The President of a country — there can only be one at a time.
/// Coffee shop analogy: A coffee shop has only one coffee machine managing the brewing queue.
/// </summary>

public sealed class CoffeeMachine
{
    private static CoffeeMachine? _instance;
    private static readonly object _lock = new();

    public string Name { get; }
    public int OrdersProcessed { get; private set; }

    private CoffeeMachine()
    {
        Name = "Breville Barista Express";
        OrdersProcessed = 0;
    }

    public static CoffeeMachine GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                _instance ??= new CoffeeMachine();
            }
        }
        return _instance;
    }

    public void Brew(string drink)
    {
        OrdersProcessed++;
        Console.WriteLine($"[{Name}] Brewing #{OrdersProcessed}: {drink}");
    }
}

public class Singleton
{
    public static void Run()
    {
        var machine1 = CoffeeMachine.GetInstance();
        var machine2 = CoffeeMachine.GetInstance();

        Console.WriteLine($"Same instance? {ReferenceEquals(machine1, machine2)}");
        Console.WriteLine($"Machine: {machine1.Name}\n");

        machine1.Brew("Espresso");
        machine2.Brew("Latte");
        machine1.Brew("Cappuccino");

        Console.WriteLine($"\nTotal orders processed: {machine1.OrdersProcessed}");
    }
}
