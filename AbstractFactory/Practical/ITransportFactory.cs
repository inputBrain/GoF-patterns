namespace AbstractFactory.Practical
{
    public interface ITransportFactory
    {
        ICar Car();

        IShip Ship();
    }
}