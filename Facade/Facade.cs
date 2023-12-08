namespace Facade
{
    public class Facade
    {
        protected Subsystem1 subsystem1;
        protected Subsystem2 subsystem2;

        public Facade(Subsystem1 s1, Subsystem2 s2)
        {
            subsystem1 = s1;
            subsystem2 = s2;
        }
        
        public string Operation()
        {
            var result = "Facade initializes subsystems:\n";
            result += subsystem1.Operation1();
            result += subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += subsystem1.OperationN();
            result += subsystem2.OperationZ();

            return result;
        }
    }
}
