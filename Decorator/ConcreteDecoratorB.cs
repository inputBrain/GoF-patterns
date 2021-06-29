namespace Decorator
{
    public class ConcreteDecoratorB : AbstractDecorator
    {
        public ConcreteDecoratorB(AbstractComponent abstractComponent) : base(abstractComponent)
        {
        }


        public override string Operation()
        {
            return $"Override operation from ConcreteDecoratorB. Base operation(): {base.Operation()}";
        }
    }
}