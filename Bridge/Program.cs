using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            BaseAbstraction baseAbstraction;

            baseAbstraction = new BaseAbstraction(new ConcreteImplementationA());
            client.ClientCode(baseAbstraction);

            baseAbstraction = new Abstraction(new ConcreteImplementationB());
            client.ClientCode(baseAbstraction);

        }
    }

    public class Client
    {
        public void ClientCode(BaseAbstraction baseAbstraction)
        {
            Console.WriteLine(baseAbstraction.Operation());
        }
    }
}