using System;

namespace Adapter.Practical
{
    public interface IUserModel
    {
        int Id { get; }

        string Description { get; }

        DateTime CreatedAt { get; }
    }
}