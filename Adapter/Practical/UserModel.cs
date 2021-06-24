using System;

namespace Adapter.Practical
{
    public class UserModel : IUserModel
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}