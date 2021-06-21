namespace AbstractFactory
{
    public interface IFruitFactory
    {
        IApple CreateApple();

        IOrange CreateOrange();
    }
}