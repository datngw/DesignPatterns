namespace DesignPatterns.Creational.FactoryMethod;

/// <summary>
/// Factory Method Pattern
///
/// Intent: Define an interface for creating an object, but let subclasses decide
/// which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
///
/// When to use:
///   - When a class can't anticipate the class of objects it must create
///   - When a class wants its subclasses to specify the objects it creates
///
/// Real-world analogy: A coffee shop franchise where each branch specializes
/// in a different drink — you walk into an EspressoBar and get an espresso,
/// or a LatteBar and get a latte. Each branch (subclass) decides which specific
/// drink to create, while the ordering process stays the same everywhere.
/// </summary>

// TODO: Implement Factory Method
// 1. Product interface
public interface ICoffee
{
    string GetName();
    void Brew();
}

// 2. Concrete products
public class Espresso : ICoffee
{
    public string GetName() => "Espresso";

    public void Brew() => Console.WriteLine("Brewing an Espresso...");
}

public class Latte : ICoffee
{
    public string GetName() => "Latte";
    public void Brew() => Console.WriteLine("Brewing a Latte...");
}

// 3. Creator abstract class with FactoryMethod()
public abstract class CoffeeFactory
{
    public abstract ICoffee CreateCoffee();
    public void OrderCoffee()
    {
        var coffee = CreateCoffee();
        Console.WriteLine($"Ordered a {coffee.GetName()}");
        coffee.Brew();
        Console.WriteLine($"{coffee.GetName()} is ready!");
    }
}

// 4. Concrete creators overriding FactoryMethod()
public class EspressoFactory : CoffeeFactory
{
    public override ICoffee CreateCoffee() => new Espresso();
}

public class LatteFactory : CoffeeFactory
{
    public override ICoffee CreateCoffee() => new Latte();
}

// Example usage
public class FactoryMethod
{
    public static void Run()
    {
        CoffeeFactory espressoFactory = new EspressoFactory();
        espressoFactory.OrderCoffee();
        Console.WriteLine();
        CoffeeFactory latteFactory = new LatteFactory();
        latteFactory.OrderCoffee();
    }
}
