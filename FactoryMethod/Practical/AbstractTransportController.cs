namespace FactoryMethod.Practical
{
    public abstract class AbstractTransportController
    {
        public abstract ITransport Transport();

        public string GetTransportInfo()
        {
            var transport = Transport();

            var info = "Transport info by abstract controller. Transport title: " + transport.Title;

            return info;
        }
    }
}