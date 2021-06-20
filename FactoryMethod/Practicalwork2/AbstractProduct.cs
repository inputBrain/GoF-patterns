namespace FactoryMethod.PracticalWork2
{
    public abstract class AbstractProduct
    {
        protected abstract IProduct Product();


        public string GetProductInfo()
        {
            var product = Product();

            var info = "Called abstract product. GetProductInfo(). Result: " + product.GetInfo();

            return info;
        }
    }
}