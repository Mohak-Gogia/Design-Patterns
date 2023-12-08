namespace Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver receiver;

        private string a;

        private string b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this.receiver = receiver;
            this.a = a;
            this.b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            receiver.DoSomething(a);
            receiver.DoSomethingElse(b);
        }
    }
}
