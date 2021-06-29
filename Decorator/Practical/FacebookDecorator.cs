using System;

namespace Decorator.Practical
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(Notifier notifier) : base(notifier)
        {
        }


        public override string Message(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}