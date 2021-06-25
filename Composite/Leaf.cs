namespace Composite
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf class";
        }


        public override bool IsComposite()
        {
            return false;
        }
    }
}