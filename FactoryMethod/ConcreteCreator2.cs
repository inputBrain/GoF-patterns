namespace FactoryMethod
{
    public class ConcreteCreator2 : AbstractCreator
    {
        public override IProduct Product()
        {
            return new ConcreteProduct2();
        }
    }
}