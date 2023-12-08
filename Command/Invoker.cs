namespace Command
{
    public class Invoker
    {
        private ICommand onStart;
        private ICommand onFinish;

        public void SetOnStart(ICommand command)
        {
            onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");

            if (onStart is ICommand)
            {
                onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");

            if (onFinish is ICommand)
            {
                onFinish.Execute();
            }
        }
    }
}
