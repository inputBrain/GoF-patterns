using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;

            Console.WriteLine("\n Standard basic product only with part A:");
            director.BuildPartA();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("\n Standard featured product with parts A and C:");
            director.BuildPartAC();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("\n Standard featured product with ALL parts:");
            director.BuildAllParts();
            Console.WriteLine(builder.GetProduct().ListParts());


            Console.WriteLine("\n \n Build concrete product without Director class:");
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}