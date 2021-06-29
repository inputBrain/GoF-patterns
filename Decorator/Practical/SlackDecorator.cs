using System;

namespace Decorator.Practical
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier notifier) : base(notifier)
        {
        }


        public override string Message(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}