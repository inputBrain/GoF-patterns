namespace AbstractFactory.Practical
{
    public class TransportFactory : ITransportFactory
    {
        public ICar Car()
        {
            return new Car();
        }


        public IShip Ship()
        {
            return new Ship();
        }
    }
}