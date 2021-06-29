using System;
using Decorator.Practical;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var component = new ConcreteComponent();

            client.ClientCode(component);


            var decorator1 = new ConcreteDecoratorA(component);
            var decorator2 = new ConcreteDecoratorB(decorator1);

            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);

            Console.WriteLine("\n  ====== Practical work =======");
            var clientPractical = new ClientPractical();
            var notifier = new Notifier();
            var fbDecorator = new FacebookDecorator(notifier);
            var slackDecorator = new SlackDecorator(notifier);
            var smsDecorator = new SMSDecorator(notifier);

            fbDecorator.Message("\n Facebook message");
            slackDecorator.Message("\n Slack decorator ");
            smsDecorator.Message("\n SMS decorator ");
            clientPractical.Main(notifier, "Notifier sms");

        }
    }


    public class Client
    {
        public void ClientCode(AbstractComponent abstractComponent)
        {
            Console.WriteLine("Abstract component operation(): " + abstractComponent.Operation());
        }
    }


    public class ClientPractical
    {
        public void Main(Notifier notifier, string message)
        {
            Console.WriteLine($"Abstract notifier message: {notifier.Message(message)}");
        }
    }
}