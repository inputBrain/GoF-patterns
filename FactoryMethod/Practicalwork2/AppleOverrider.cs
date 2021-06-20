namespace FactoryMethod.PracticalWork2
{
    public class AppleOverrider : AbstractProduct
    {
        protected override IProduct Product()
        {
            return new AppleModel();
        }
    }
}