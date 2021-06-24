using System;

namespace Bridge.Practical
{
    public class ProductA : IMain
    {
        public string Operation()
        {
            return "Result of operation from Product A";
        }


        public int SumOfTwoNumbers(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"{a} + {b} = {result}. Product A");
            return result;
        }
    }
}