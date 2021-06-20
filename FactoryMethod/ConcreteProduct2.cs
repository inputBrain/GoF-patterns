namespace FactoryMethod
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Reaction by calling the operation from product 2}";
        }
    }
}