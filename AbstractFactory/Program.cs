using System;
using AbstractFactory.Practical;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Client().Main();

            //Practical.
            new ClientPractical().Main();
        }
    }

    class Client
    {
        public void ClientMethod(IFruitFactory factory)
        {
            var apple = factory.CreateApple();
            var orange = factory.CreateOrange();

            Console.WriteLine(orange.Title);
            Console.WriteLine(orange.UsefulFunction(apple));
        }

        public void Main()
        {
            ClientMethod(new FruitFactory());
        }
    }


    class ClientPractical
    {
        public void CreateFactory(ITransportFactory transportFactory)
        {
            var car = transportFactory.Car();
            var ship = transportFactory.Ship();

            Console.WriteLine("Factories were created by ClientPractical class. \n");
            Console.WriteLine("Car's method DoBeep: " + car.DoBeep());
            Console.WriteLine("Ship's method DoBeep: " + ship.DoBeep());
        }


        public void Main()
        {
            CreateFactory(new TransportFactory());
        }
    }
}