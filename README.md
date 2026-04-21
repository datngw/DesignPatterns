# Design Patterns - Coffee Shop Edition

A hands-on project for learning the 23 classic GoF (Gang of Four) design patterns using **C# / .NET 9**, with examples grounded in a **coffee shop** domain.

Each pattern lives in its own folder with clear documentation, real-world analogies, and runnable code.

## Why Coffee Shop?

A coffee shop is a domain everyone understands, yet it naturally involves the kinds of problems design patterns solve — varied drink menus, custom orders, dynamic pricing, inventory tracking, and customer notifications. By mapping each pattern to a familiar coffee shop scenario, the intent and mechanics of the pattern become intuitive rather than abstract.

## Project Structure

```
src/
├── Creational/          # Patterns that deal with object creation
│   ├── FactoryMethod/       ✅ Coffee factories (Espresso, Latte, etc.)
│   ├── AbstractFactory/     🔲 Matching product families
│   ├── Builder/             🔲 Step-by-step custom coffee orders
│   ├── Prototype/           🔲 Cloning drink recipes
│   └── Singleton/           🔲 One shared coffee machine / config
│
├── Structural/          # Patterns that deal with object composition
│   ├── Adapter/             🔲 Third-party payment integration
│   ├── Bridge/              🔲 Abstraction for brewing methods vs. drink types
│   ├── Composite/           🔲 Menu groups (combos, meal deals)
│   ├── Decorator/           🔲 Toppings and add-ons (milk, syrup, whip)
│   ├── Facade/              🔲 Simplified ordering interface
│   ├── Flyweight/           🔲 Shared immutable drink templates
│   └── Proxy/               🔲 Access control for premium drinks
│
└── Behavioral/          # Patterns that deal with object interaction
    ├── ChainOfResponsibility/ 🔲 Order validation pipeline
    ├── Command/              🔲 Order queue with undo/redo
    ├── Iterator/             🔲 Traverse menu items
    ├── Mediator/             🔲 Barista-cashier coordination
    ├── Memento/              🔲 Save/restore order state
    ├── Observer/             🔲 "Your order is ready" notifications
    ├── State/                🔲 Order lifecycle (pending → brewing → done)
    ├── Strategy/             🔲 Pricing strategies (happy hour, loyalty)
    ├── TemplateMethod/       🔲 Brewing algorithm skeleton
    └── Visitor/              🔲 Apply discounts/taxes across menu items
```

## Patterns at a Glance

### Creational

| Pattern | Coffee Shop Scenario | Status |
|---------|---------------------|--------|
| **Factory Method** | A coffee factory creates specific drinks based on the factory type | ✅ Done |
| **Abstract Factory** | Create matching product families (drink + pastry + cup style) | 🔲 Todo |
| **Builder** | Build a custom coffee step by step (size, milk, syrup, toppings) | 🔲 Todo |
| **Prototype** | Clone an existing drink recipe as a starting point for variations | 🔲 Todo |
| **Singleton** | Ensure only one coffee machine instance manages the brewing queue | 🔲 Todo |

### Structural

| Pattern | Coffee Shop Scenario | Status |
|---------|---------------------|--------|
| **Adapter** | Integrate a third-party payment provider into the existing system | 🔲 Todo |
| **Bridge** | Decouple brewing method (espresso machine, pour-over) from drink type | 🔲 Todo |
| **Composite** | Treat single drinks and combo meals uniformly in the menu | 🔲 Todo |
| **Decorator** | Dynamically add milk, syrup, whipped cream on top of a base drink | 🔲 Todo |
| **Facade** | Provide a simple `OrderCoffee()` method hiding the complex subsystem | 🔲 Todo |
| **Flyweight** | Share immutable drink base templates to reduce memory | 🔲 Todo |
| **Proxy** | Control access to premium/specialty drinks | 🔲 Todo |

### Behavioral

| Pattern | Coffee Shop Scenario | Status |
|---------|---------------------|--------|
| **Chain of Responsibility** | Pass an order through validation steps (stock check → payment → brew) | 🔲 Todo |
| **Command** | Encapsulate orders as objects for queuing, undo, and redo | 🔲 Todo |
| **Iterator** | Traverse the menu without exposing its internal structure | 🔲 Todo |
| **Mediator** | Centralize communication between barista, cashier, and display | 🔲 Todo |
| **Memento** | Save and restore an order's state (e.g., customer changes their mind) | 🔲 Todo |
| **Observer** | Notify customers when their order is ready | 🔲 Todo |
| **State** | Change behavior as an order moves through its lifecycle | 🔲 Todo |
| **Strategy** | Swap pricing algorithms (regular, happy hour, loyalty discount) | 🔲 Todo |
| **Template Method** | Define the brewing skeleton; subclasses customize specific steps | 🔲 Todo |
| **Visitor** | Apply operations (tax, discount, nutritional info) across menu items | 🔲 Todo |

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

### Run a Pattern

Each category (Creational, Structural, Behavioral) is its own project with an interactive menu:

```bash
# Run creational patterns
dotnet run --project src/Creational

# Run structural patterns
dotnet run --project src/Structural

# Run behavioral patterns
dotnet run --project src/Behavioral
```

## License

This project is for educational purposes.
