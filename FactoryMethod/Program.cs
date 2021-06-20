using System;
using FactoryMethod.Practical;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

    class Client
    {
        public void ClientCode(AbstractTransportController abstractTransport)
        {
            Console.WriteLine("Get transport info: " + abstractTransport.GetTransportInfo());
        }

        public void Main()
        {
            Console.WriteLine("Car controller.");
            ClientCode(new CarController());

            Console.WriteLine("");

            Console.WriteLine("Boat controller.");
            ClientCode(new BoatController());

            Console.WriteLine("");

            Console.WriteLine("Ship controller.");
            ClientCode(new ShipController());
        }
    }

    // Example from book :

    // class Client
    // {
    //     public void ClientCode(AbstractCreator abstractCreator)
    //     {
    //         Console.WriteLine("Client: I'm not aware of the creator's class," +
    //             "but it still works.\n" + abstractCreator.MainOperation());
    //     }
    //
    //     public void Main()
    //     {
    //         Console.WriteLine("App: Launched with the ConcreteCreator1.");
    //         ClientCode(new ConcreteCreator1());
    //
    //         Console.WriteLine("");
    //
    //         Console.WriteLine("App: Launched with the ConcreteCreator2.");
    //         ClientCode(new ConcreteCreator2());
    //     }
    // }
}