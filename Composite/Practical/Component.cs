namespace Composite.Practical
{
    public class Component : AbstractTree
    {
        public override string Operation()
        {
            return "This message from Component : AbstractTree";
        }

        public override bool IsComposite()
        {
            return true;
        }


    }
}