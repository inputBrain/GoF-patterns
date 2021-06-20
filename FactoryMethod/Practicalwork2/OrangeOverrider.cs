namespace FactoryMethod.PracticalWork2
{
    public class OrangeOverrider : AbstractProduct
    {
        protected override IProduct Product()
        {
            return new OrangeModel();
        }
    }
}