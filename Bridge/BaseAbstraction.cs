namespace Bridge
{
    public class BaseAbstraction : IImplementation
    {
        protected readonly IImplementation Implementation;


        public BaseAbstraction(IImplementation implementation)
        {
            Implementation = implementation;
        }


        public virtual string Operation()
        {
            return "BaseAbstraction: BaseAbstraction operation with:\n" +
                Implementation.Operation();
        }
    }
}