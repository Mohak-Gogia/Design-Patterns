#region Main method

using Decorator;

internal static class Program
{
    static void Main()
    {
        var client = new Client();

        var simple = new ConcreteComponent();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(simple);
        Console.WriteLine();
        var decoratorA = new ConcreteDecoratorA(simple);
        var decoratorB = new ConcreteDecoratorB(decoratorA);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.ClientCode(decoratorB);
    }
}

#endregion