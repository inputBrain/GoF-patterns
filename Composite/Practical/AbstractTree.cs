namespace Composite.Practical
{
    public abstract class AbstractTree
    {
        public abstract string Operation();


        public virtual void AddComponentToThree(AbstractTree abstractTree)
        {
        }


        public virtual void RemoveComponentFromThree(AbstractTree abstractTree)
        {
        }


        public virtual bool IsComposite()
        {
            return true;
        }
    }
}