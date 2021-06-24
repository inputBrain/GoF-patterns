using System;
using Adapter.Practical.Message;

namespace Adapter.Practical
{
    public class UserController
    {
        public Message.GetOneUser.Response GetUser()
        {
            var user = new UserModel()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                Description = "Server user description"
            };
            Console.WriteLine($"---- id: {user.Id} ");
            Console.WriteLine($"---- CreatedAt: {user.CreatedAt.ToString("d")} ");
            Console.WriteLine($"---- Description: {user.Description} ");

            var encodedUser = Adapter.EncodeUser(user);

            return new GetOneUser.Response(encodedUser);
        }
    }
}