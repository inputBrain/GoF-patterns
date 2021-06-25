using System.Collections.Generic;

namespace Composite.Practical
{
    public class Tree : AbstractTree
    {
        protected List<AbstractTree> _trees = new List<AbstractTree>();

        public override string Operation()
        {
            throw new System.NotImplementedException();
        }
    }
}