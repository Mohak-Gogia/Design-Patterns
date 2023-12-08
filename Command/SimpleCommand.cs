namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string payload;

        public SimpleCommand(string payload)
        {
            this.payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({payload})");
        }
    }
}
