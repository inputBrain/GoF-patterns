namespace FactoryMethod.Practical
{
    public class CarController : AbstractTransportController
    {
        public override ITransport Transport()
        {
            return new CarModel();
        }
    }
}