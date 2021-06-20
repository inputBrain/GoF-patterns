namespace FactoryMethod
{
    public class ConcreteCreator1 : AbstractCreator
    {
        public override IProduct Product()
        {
            return new ConcreteProduct1();
        }
    }
}