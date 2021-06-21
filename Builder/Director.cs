namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }


        public void BuildPartA()
        {
            _builder.BuildPartA();
        }


        public void BuildPartAC()
        {
            _builder.BuildPartA();
            _builder.BuildPartC();
        }


        public void BuildAllParts()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}