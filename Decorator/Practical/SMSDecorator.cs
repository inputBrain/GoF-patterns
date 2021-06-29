using System;

namespace Decorator.Practical
{
    public class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(Notifier notifier) : base(notifier)
        {
        }


        public override string Message(string message)
        {
            Console.WriteLine(message);
            return message;
        }


    }
}