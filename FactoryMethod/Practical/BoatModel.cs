namespace FactoryMethod.Practical
{
    public class BoatModel : ITransport
    {
        public int Id { get; set; }

        public string Title
        {
            get => new string("The boat is going to the island!");
        }

        public string Cover
        {
            get => new string("Perfect cover for the boat");
        }
    }
}