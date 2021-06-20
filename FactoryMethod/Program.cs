using System;
using FactoryMethod.Practical;
using FactoryMethod.PracticalWork2;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\n Example from the book:");
            // new BookExampleClient().Main();

            // Console.WriteLine("\n Practical:");
            // new TransportClient().Main();

            // Console.WriteLine("\n Practical work #2:");
            new ProductWorker().Creator();
        }
    }

    //Practical work #1.
    class TransportClient
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

    //Practical work #2.
    class ProductWorker
    {
        public void ProductInfo(AbstractProduct abstractProduct)
        {
            Console.WriteLine("Product info." + abstractProduct.GetProductInfo());
        }


        public void Creator()
        {
            ProductInfo(new AppleOverrider());
            ProductInfo(new OrangeOverrider());
        }
    }


    // Example from the book.
    class BookExampleClient
    {
        public void ClientCode(AbstractCreator abstractCreator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + abstractCreator.MainOperation());
        }

        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }
    }
}