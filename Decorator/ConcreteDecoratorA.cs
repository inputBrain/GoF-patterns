namespace Decorator
{
    public class ConcreteDecoratorA : AbstractDecorator
    {
        public ConcreteDecoratorA(AbstractComponent abstractComponent) : base(abstractComponent)
        {
        }


        public override string Operation()
        {
            return $"Override operation from ConcreteDecoratorA. Base.Operation(): ({base.Operation()})";
        }
    }
}