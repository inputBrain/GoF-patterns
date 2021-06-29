namespace Decorator.Practical
{
    public class Notifier
    {
        public virtual string Message(string message)
        {
            return $"Message was called from AbstractNotifier. Message: {message}";
        }
    }
}