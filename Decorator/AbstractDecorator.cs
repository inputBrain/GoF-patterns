namespace Decorator
{
    public abstract class AbstractDecorator : AbstractComponent
    {
        protected AbstractComponent AbstractComponent;


        protected AbstractDecorator(AbstractComponent abstractComponent)
        {
            AbstractComponent = abstractComponent;
        }


        public void SetAbstractComponent(AbstractComponent abstractComponent)
        {
            AbstractComponent = abstractComponent;
        }


        public override string Operation()
        {
            return AbstractComponent != null ? AbstractComponent.Operation() : string.Empty;
        }
    }
}