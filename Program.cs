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
            BinarySearchTree bst = new BinarySearchTree();

            bst.AddNode(new Node(100));
            bst.AddNode(new Node(50));
            bst.AddNode(new Node(150));
            bst.AddNode(new Node(40));
            bst.AddNode(new Node(75));
            bst.AddNode(new Node(125));
            bst.AddNode(new Node(175));

            Console.ReadLine();
        }
    }
}
