namespace FactoryMethod.Practical
{
    public class BoatController : AbstractTransportController
    {
        public override ITransport Transport()
        {
            return new BoatModel();
        }
    }
}