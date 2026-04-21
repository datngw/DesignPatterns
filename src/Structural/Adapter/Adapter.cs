namespace DesignPatterns.Structural.Adapter;

/// <summary>
/// Adapter Pattern
///
/// Intent: Convert the interface of a class into another interface clients expect.
/// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
///
/// When to use:
///   - When you want to use an existing class, and its interface does not match the one you need
///   - When you want to create a reusable class that cooperates with unrelated or unforeseen classes
///
/// Real-world analogy: A coffee shop integrates a third-party payment provider (SuperPay).
/// The POS system expects IPaymentProcessor, but SuperPay has its own interface (MakeTransaction).
/// The adapter wraps SuperPay and translates calls so the POS can process payments without changes.
/// </summary>

// TODO: Implement Adapter
// 1. Target interface (what the client expects)
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
// 2. Adaptee class (existing incompatible class)
public class SuperPayService
{
    public void MakeTransaction(double val, string currency)
    {
        Console.WriteLine(val + " " + currency + " processed by SuperPayService");
    }
}
// 3. Adapter class that implements Target and wraps Adaptee
public class SupperPayAdaper : IPaymentProcessor
{
    private readonly SuperPayService _superPayService;
    public SupperPayAdaper(SuperPayService superPayService)
    {
        _superPayService = superPayService;
    }
    public void ProcessPayment(decimal amount)
    {
        // Convert decimal amount to double and specify currency for SuperPayService
        double convertedAmount = (double)amount;
        string currency = "VND";

        // Call the method of the Adaptee class using the converted parameters
        _superPayService.MakeTransaction(convertedAmount, currency);
    }
}

public class Adapter
{
    public static void Run()
    {
        // Client code expects IPaymentProcessor, but we have SuperPayService
        SuperPayService superPayService = new SuperPayService();

        // We create an adapter that wraps the SuperPayService
        // and implements the IPaymentProcessor interface
        IPaymentProcessor paymentProcessor = new SupperPayAdaper(superPayService);

        // Now the client can use the paymentProcessor to process payments,
        // and it will internally call the SuperPayService with the correct parameters
        paymentProcessor.ProcessPayment(45000m);
    }
}

