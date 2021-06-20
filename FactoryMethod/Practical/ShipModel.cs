namespace FactoryMethod.Practical
{
    public class ShipModel : ITransport
    {
        public int Id { get; set; }

        public string Title
        {
            get => new string("The ship is going to the port!");
        }

        public string Cover
        {
            get => new string("Perfect cover for the ship");
        }
    }
}