using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //Naive Singleton.
            Console.WriteLine("\n Naive Singleton:");
            var s1 = Naive.Singleton.GetInstance();
            var s2 = Naive.Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }


            // DoubleCheckLock Singleton
            Console.WriteLine("\n DoubleCheckLock Singleton:");
            var thread1 = new Thread(() =>
            {
                TestDoubleCheckLockSingleton("Message from thread 1.");
            });
            var thread2 = new Thread(() =>
            {
                TestDoubleCheckLockSingleton("Setting value by thread 2. This shouldn't appear in console");
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }


        public static void TestDoubleCheckLockSingleton(string value)
        {
            var singleton = DoubleCheckLock.Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}