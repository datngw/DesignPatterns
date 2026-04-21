namespace DesignPatterns.Creational.Builder;

/// <summary>
/// Builder Pattern
///
/// Intent: Separate the construction of a complex object from its representation
/// so that the same construction process can create different representations.
///
/// When to use:
///   - When the algorithm for creating a complex object should be independent
///     of the parts that make up the object and how they're assembled
///   - When the construction process must allow different representations of the constructed object
///
/// Real-world analogy: Ordering a custom coffee at a coffee shop — you specify
/// the size, choose your milk, add syrups and toppings step by step. The barista
/// (builder) assembles your drink exactly as you described, and the same ordering
/// process can produce a cappuccino, latte, or any custom creation.
/// </summary>

// TODO: Implement Builder
// 1. Product class with many properties
public class Coffee
{
    public string Size { get; set; } = string.Empty;
    public string Milk { get; set; } = string.Empty;
    public string Syrup { get; set; } = string.Empty;
    public List<string> Toppings { get; set; } = new();

    public void ShowDetails()
    {
        Console.WriteLine($"------- Your Coffee Order -------");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Milk: {Milk ?? "None"}");
        Console.WriteLine($"Syrup: {Syrup ?? "None"}");
        if (Toppings.Count > 0)
        {
            Console.WriteLine($"Toppings: {string.Join(", ", Toppings)}");
        }
        else
        {
            Console.WriteLine("Toppings: None");
        }
    }
}
// 2. Builder interface with step methods
public interface ICoffeeBuilder
{
    ICoffeeBuilder SetSize(string size);
    ICoffeeBuilder AddMilk(string milk);
    ICoffeeBuilder AddSyrup(string syrup);
    ICoffeeBuilder AddTopping(string topping);
    Coffee Build();
}
// 3. Concrete builders
public class CoffeeBuilder : ICoffeeBuilder
{
    private Coffee _coffee = new Coffee();
    public ICoffeeBuilder AddMilk(string milk)
    {
        _coffee.Milk = milk;
        return this;
    }

    public ICoffeeBuilder SetSize(string size)
    {
        _coffee.Size = size;
        return this;
    }

    public ICoffeeBuilder AddSyrup(string syrup)
    {
        _coffee.Syrup = syrup;
        return this;
    }

    public ICoffeeBuilder AddTopping(string topping)
    {
        _coffee.Toppings.Add(topping);
        return this;
    }

    public Coffee Build()
    {
        Coffee finishedCoffee = _coffee;
        _coffee = new Coffee(); // Reset for next build
        return finishedCoffee;
    }
}
// 4. Director class (optional) that orchestrates building steps
public class CoffeeDirector
{
    public Coffee MakeCappuccino(ICoffeeBuilder builder)
    {
        return builder.SetSize("Medium")
                      .AddMilk("Whole Milk")
                      .AddSyrup("Vanilla")
                      .AddTopping("Cinnamon")
                      .Build();
    }

    public Coffee MakeLatte(ICoffeeBuilder builder)
    {
        return builder.SetSize("Large")
                      .AddMilk("Skim Milk")
                      .AddSyrup("Caramel")
                      .AddTopping("Whipped Cream")
                      .Build();
    }
}

public class Builder
{
    public static void Run()
    {
        var builder = new CoffeeBuilder();
        var director = new CoffeeDirector();

        // Using builder directly to create a custom coffee order
        Coffee customCoffee = builder
            .SetSize("Small")
            .AddMilk("Almond Milk")
            .AddSyrup("Hazelnut")
            .AddTopping("Chocolate Chips")
            .Build();

        Console.WriteLine("Custom Coffee Created:");
        customCoffee.ShowDetails();

        // Using Director to create predefined coffee orders
        Coffee cappuccino = director.MakeCappuccino(builder);
        cappuccino.ShowDetails();

    }
}
