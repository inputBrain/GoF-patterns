using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var leaf = new Leaf();

            Console.WriteLine("Client: i get a simple component:");
            client.ClientCode(leaf);

            var tree = new Composite();
            var branch1 = new Composite();

            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            var branch2 = new Composite();
            branch2.Add(new Leaf());

            tree.Add(branch1);
            tree.Add(branch2);


            Console.WriteLine("Client: Now, i've got a component tree:");
            client.ClientCode(tree);


            Console.WriteLine("Client: I don't need to check the components classes event when managing the three:\n");
            client.ClientCode2(tree, leaf);

        }
    }

    class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine($"RESULT: {component.Operation()} \n");
        }


        public void ClientCode2(Component component, Component component2)
        {
            if (component.IsComposite())
            {
                component.Add(component2);
            }

            Console.WriteLine($"RESULT: {component.Operation()} \n");

        }
    }
}