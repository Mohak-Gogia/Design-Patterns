sealed class Singleton
{
    private static Singleton _instance;

    private Singleton()
    {
    }

    private static readonly object _lock = new(); // thread safety singleton

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }

        return _instance;
    }
}

#region Main method

internal class Program
{
    static void Main()
    {
        var obj1 = Singleton.GetInstance();
        var obj2 = Singleton.GetInstance();

        if (obj1 == obj2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }
    }
}

#endregion