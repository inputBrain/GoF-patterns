using System;
using Bridge.Practical;

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

            Console.WriteLine("\n====== Practical work. ======");

            var clientPractical = new ClientPractical();
            BaseController baseController;

            baseController = new BaseController(new ProductA());
            clientPractical.Main(baseController);

            baseController = new Controller(new ProductA());
            clientPractical.Main(baseController);
        }
    }

    public class Client
    {
        public void ClientCode(BaseAbstraction baseAbstraction)
        {
            Console.WriteLine(baseAbstraction.Operation());
        }
    }

    public class ClientPractical
    {
        public void Main(BaseController baseController)
        {
            Console.WriteLine(baseController.Operation());
            Console.WriteLine(baseController.SumOfTwoNumbers(5, 5));
        }
    }
}