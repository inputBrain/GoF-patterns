using System;

namespace Bridge.Practical
{
    public class Controller : BaseController
    {
        public Controller(IMain implementation) : base(implementation)
        {
        }


        public override string Operation()
        {
            return "This is an override message from Controller";
        }


        public override int SumOfTwoNumbers(int a, int b)
        {
            Console.WriteLine("Sum of two numbers? ho-ho! Lets override it and add a number to sum three numbers!");
            var confusedResult = a + b + 10;
            Console.WriteLine($"{a} + {b} + {10} = {confusedResult}");
            return confusedResult;
        }
    }
}