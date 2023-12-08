namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            product = new();
        }

        public void BuildPartA()
        {
            product.Add("Part A1");
        }

        public void BuildPartB()
        {
            product.Add("Part B1");
        }

        public void BuildPartC()
        {
            product.Add("Part C1");
        }
        public Product GetProduct()
        {
            var result = product;

            Reset();

            return result;
        }
    }
}
