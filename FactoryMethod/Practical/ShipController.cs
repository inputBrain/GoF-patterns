namespace FactoryMethod.Practical
{
    public class ShipController : AbstractTransportController
    {
        public override ITransport Transport()
        {
            return new ShipModel();
        }
    }
}