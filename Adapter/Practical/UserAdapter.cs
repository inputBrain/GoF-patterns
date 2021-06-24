using System;
using Adapter.Practical.Payload;

namespace Adapter.Practical
{
    public static class Adapter
    {
        public static User EncodeUser(IUserModel user)
        {
            return new User()
            {
                Id = user.Id,
                Description = user.Description,
                CreatedAt = ToUnixTime(user.CreatedAt)
            };
        }

        public static int ToUnixTime(DateTimeOffset date)
        {
            return checked((int) date.ToUnixTimeSeconds());
        }
    }
}