namespace AbstractFactory
{
    public class FruitFactory : IFruitFactory
    {
        public IApple CreateApple()
        {
            return new AppleModel();
        }


        public IOrange CreateOrange()
        {
            return new OrangeModel();
        }
    }
}