#region Main method

using Command;

internal class Program
{
    static void Main()
    {
        var invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Say Hi!"));

        var receiver = new Receiver();
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

        invoker.DoSomethingImportant();
    }
}

#endregion