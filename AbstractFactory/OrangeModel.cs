namespace AbstractFactory
{
    public class OrangeModel : IOrange
    {
        public string Title
        {
            get => new string("Orange model title");
        }

        public string UsefulFunction(IApple apple)
        {
            return $"The result of the Orange Model collaborating with the ({apple.Title})";
        }
    }
}