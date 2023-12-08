#region Main method

using Facade;

internal class Program
{
    static void Main()
    {
        var subsystem1 = new Subsystem1();
        var subsystem2 = new Subsystem2();

        var facade = new Facade.Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }
}

#endregion