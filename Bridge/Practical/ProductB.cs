using System;

namespace Bridge.Practical
{
    public class ProductB : IMain
    {
        public string Operation()
        {
            return "Result of operation from Product B";
        }


        public int SumOfTwoNumbers(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"{a} + {b} = {result}. Product B");
            return result;
        }
    }
}