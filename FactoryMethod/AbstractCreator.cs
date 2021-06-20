namespace FactoryMethod
{
    public abstract class AbstractCreator
    {
        public abstract IProduct Product();


        public string MainOperation()
        {
            var product = Product();

            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }
}