namespace Bridge
{
    public class Abstraction : BaseAbstraction
    {
        public Abstraction(IImplementation implementation) : base(implementation)
        {
        }


        public override string Operation()
        {
            return "Abstraction: operation with:\n" +
                Implementation.Operation();
        }
    }
}