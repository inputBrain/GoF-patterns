namespace FactoryMethod.Practical
{
    public class CarModel : ITransport
    {
        public int Id { get; set; }

        public string Title
        {
            get => new string("The car is going to the shop!");
        }

        public string Cover
        {
            get => new string("Perfect cover for the car");
        }
    }
}