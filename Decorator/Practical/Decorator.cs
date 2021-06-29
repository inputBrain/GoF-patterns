namespace Decorator.Practical
{
    public class Decorator : Notifier
    {
        public override string Message(string message)
        {
            return message;
        }
    }
}