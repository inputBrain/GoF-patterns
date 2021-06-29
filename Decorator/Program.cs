using System;

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
        }
    }


    public class Client
    {
        public void ClientCode(AbstractComponent abstractComponent)
        {
            Console.WriteLine("Abstract component operation(): " + abstractComponent.Operation());
        }
    }
}