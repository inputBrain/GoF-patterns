using System;

namespace AbstractFactory
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
}