using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            BinarySearchTree bst = new BinarySearchTree();

            //RunBinaryTreeTest(bst);
            //Console.ReadLine();
            //Console.Clear();

            BinarySearchTree bstRng = new BinarySearchTree();
            AddRandomNodes(bstRng, 100, rng);



            Console.ReadLine();
        }

        public static void RunBinaryTreeTest(BinarySearchTree bst)
        {
            Node lion = new Node(100, "Lion");
            Node giraffe = new Node(50, "Giraffe");
            Node seal = new Node(150, "Seal");
            Node monkey = new Node(40, "Monkey");
            Node tiger = new Node(75, "Tiger");
            Node buffalo = new Node(125, "Buffalo");
            Node kangaroo = new Node(175, "Kangaroo");
            Node dinosaur = new Node(42, "Dinosaur");
            bst.AddNode(lion);
            bst.AddNode(lion);
            bst.AddNode(giraffe);
            bst.AddNode(seal);
            bst.AddNode(monkey);
            bst.AddNode(tiger);
            bst.AddNode(buffalo);
            bst.AddNode(kangaroo);
            bst.AddNode(dinosaur);
            bst.AddNode(new Node(40));

            Node foundNode;

            Console.WriteLine($"Searching for: {lion}");
            foundNode = bst.Search(lion);
            Console.WriteLine($"Found Node: {foundNode}");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Searching for: {giraffe}");
            foundNode = bst.Search(giraffe);
            Console.WriteLine($"Found Node: {foundNode}");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Searching for: {seal}");
            foundNode = bst.Search(seal);
            Console.WriteLine($"Found Node: {foundNode}");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Searching for: {buffalo}");
            foundNode = bst.Search(buffalo);
            Console.WriteLine($"Found Node: {foundNode}");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Searching for: {dinosaur}");
            foundNode = bst.Search(dinosaur);
            Console.WriteLine($"Found Node: {foundNode}");
            Console.WriteLine("----------------------------");

            Node bird = new Node(12, "Bird");
            Console.WriteLine($"Search for {bird}.\n It has not been added to the list.");
            foundNode = bst.Search(bird);
        }

        public static void AddRandomNodes(BinarySearchTree bst, int amount, Random rng)
        {
            int key = 0;
            for (int i = 0; i < amount; i++)
            {
                key = rng.Next(0, 501);
                char[] data = new char[5];
                for (int j = 0; j < 5; j++)
                {
                    data[j] = Convert.ToChar(rng.Next(65, 92));
                }
                bst.AddNode(new Node(key, new string(data)));
            }

        }
    }
}
