namespace Adapter.Practical.Message
{
    public sealed class GetOneUser
    {
        public sealed class Response
        {
            public Payload.User User { get; }

            public Response(Payload.User user)
            {
                User = user;
            }
        }
    }
}