
// Adaptor pattern is a structural design pattern that allows objects with incompatible interfaces to work together.
// It acts as a bridge between two incompatible interfaces by converting the interface of one class into an interface expected by the clients.
var thirdPartyLogger = new DesignPatternsDemo.Adaptor.ThirdPartyLogger();
var logger = new DesignPatternsDemo.Adaptor.ThirdPartyLoggerAdaptor(thirdPartyLogger);

var app = new DesignPatternsDemo.Adaptor.App(logger);
app.Run();
Console.WriteLine("****************************************************************");


// Builder pattern is a creational design pattern that allows for the step-by-step construction of complex objects.
// It separates the construction of an object from its representation, allowing the same construction process to create different representations.
var ranchPizza = new DesignPatternsDemo.Builder.Pizza.Builder()
    .WithCrust("Thin")
    .WithSauce("Ranch")
    .WithToppings("Chicken, Bacon, Cheese")
    .Build();

var bbqPizza = new DesignPatternsDemo.Builder.Pizza.Builder()
    .WithCrust("Thick")
    .WithSauce("BBQ")
    .WithToppings("Beef, Onion, Pickles")
    .Build();

Console.WriteLine(ranchPizza);
Console.WriteLine(bbqPizza);
Console.WriteLine("\n****************************************************************\n");

// Composite pattern is a structural design pattern that allows you to compose objects into tree-like structures to represent part-whole hierarchies.
// It lets clients treat individual objects and compositions of objects uniformly.
var file1 = new DesignPatternsDemo.Composite.File("File1.txt", 100);
var file2 = new DesignPatternsDemo.Composite.File("File2.txt", 200);
var rootFolder = new DesignPatternsDemo.Composite.Folder("Root");
rootFolder.Add(file1);
rootFolder.Add(file2);
Console.WriteLine(rootFolder.GetSize());
Console.WriteLine("\n****************************************************************\n");

// Decorator pattern is a structural design pattern that allows behavior to be added to individual objects,
// either statically or dynamically, without affecting the behavior of other objects from the same class.
var simpleCoffee = new DesignPatternsDemo.Decorator.SimpleCoffe();
Console.WriteLine(simpleCoffee.GetDesciption());
Console.WriteLine(simpleCoffee.GetCost());

var darkCoffee = new DesignPatternsDemo.Decorator.DarkCoffeDecorator(simpleCoffee);
Console.WriteLine(darkCoffee.GetDesciption());
Console.WriteLine(darkCoffee.GetCost());

var whiteCoffe = new DesignPatternsDemo.Decorator.WhiteCoffeDecorator(simpleCoffee);
Console.WriteLine(whiteCoffe.GetDesciption());
Console.WriteLine(whiteCoffe.GetCost());
Console.WriteLine("\n****************************************************************\n");

// Facade pattern is a structural design pattern that provides a simplified interface to a larger body of code, such as a class library.
var tv = new DesignPatternsDemo.Facade.TV();
var dvd = new DesignPatternsDemo.Facade.Dvd();
var homeTheater = new DesignPatternsDemo.Facade.HomeMovieTheater(dvd, tv);
homeTheater.WatchMovie("Inception");
Console.WriteLine("\n****************************************************************\n");

// Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to it.
var logger1 = DesignPatternsDemo.Singlton.Logger.Instance;
var logger2 = DesignPatternsDemo.Singlton.Logger.Instance;
logger1.Log("This is a log message from logger1.");
logger2.Log("This is a log message from logger2.");

Console.WriteLine(logger1 == logger2); // Output: True, both logger1 and logger2 refer to the same instance
Console.WriteLine("\n****************************************************************\n");


// Factory Method pattern is a creational design pattern that provides an interface for creating objects in a superclass,
var factory = new DesignPatternsDemo.Factory.EmailNotificationFactory();
var app2 = new DesignPatternsDemo.Factory.App2(factory);
app2.SendNotification();
Console.WriteLine("\n****************************************************************\n");

