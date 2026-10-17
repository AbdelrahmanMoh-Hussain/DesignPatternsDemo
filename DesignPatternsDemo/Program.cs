// Adaptor pattern is a structural design pattern that allows objects with incompatible interfaces to work together.
// It acts as a bridge between two incompatible interfaces by converting the interface of one class into an interface expected by the clients.
var thirdPartyLogger = new DesignPatternsDemo.Adaptor.ThirdPartyLogger();
var logger = new DesignPatternsDemo.Adaptor.ThirdPartyLoggerAdaptor(thirdPartyLogger);

var app = new DesignPatternsDemo.Adaptor.App(logger);
app.Run();


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