namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();


        public void Reset()
        {
            _product = new Product();
        }

        public ConcreteBuilder()
        {
            Reset();
        }


        public void BuildPartA()
        {
            _product.Add("Part A");
        }


        public void BuildPartB()
        {
            _product.Add("Part B");
        }


        public void BuildPartC()
        {
            _product.Add("Part C");
        }


        public Product GetProduct()
        {
            var result = _product;
            Reset();

            return result;
        }
    }
}