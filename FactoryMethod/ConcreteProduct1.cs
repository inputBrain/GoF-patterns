namespace FactoryMethod
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Reaction by calling the operation from product 1}";
        }
    }
}