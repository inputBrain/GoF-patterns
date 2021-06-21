namespace AbstractFactory
{
    public interface IOrange
    {
        string Title { get; }

        string UsefulFunction(IApple apple);

    }
}