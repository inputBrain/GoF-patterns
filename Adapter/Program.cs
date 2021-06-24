using System;
using Adapter.Practical;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();

            var target = new Adapter(adaptee);


            Console.WriteLine(target.GetRequest());


            Console.WriteLine("\n ===== Practical work =====");
            var userController = new UserController();

            var response = userController.GetUser();
            Console.WriteLine($"Id: {response.User.Id}");
            Console.WriteLine($"CreatedAt. Should be Unix time in seconds: {response.User.CreatedAt}");
            Console.WriteLine($"Description: {response.User.Description}");
        }
    }
}