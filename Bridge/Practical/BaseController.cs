using System;

namespace Bridge.Practical
{
    public class BaseController : IMain
    {
        protected readonly IMain Implementation;


        public BaseController(IMain implementation)
        {
            Implementation = implementation;
        }


        public virtual string Operation()
        {
            return "BaseController message! Hello from Operation()";
        }


        public virtual int SumOfTwoNumbers(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Counted result. {a} + {b} = {result}");
            return result;
        }
    }
}