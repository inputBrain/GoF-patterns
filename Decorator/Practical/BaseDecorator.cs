namespace Decorator.Practical
{
    public abstract class BaseDecorator : Notifier
    {
        private readonly Notifier _notifier;


        protected BaseDecorator(Notifier notifier)
        {
            _notifier = notifier;
        }


        public override string Message(string message)
        {
            return _notifier != null ? _notifier.Message(message) : string.Empty;
        }
    }
}