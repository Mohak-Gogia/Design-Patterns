public interface ITarget
{
    string GetRequest();
}

public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific Request";
    }
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adapteeObject)
    {
        _adaptee = adapteeObject;
    }

    public string GetRequest()
    {
        return $"This is {_adaptee.GetSpecificRequest()}";
    }
}


#region Main method

internal class Program
{
    static void Main()
    {
        var adaptee = new Adaptee();
        var target = new Adapter(adaptee);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.");

        Console.WriteLine(target.GetRequest());
    }
}

#endregion