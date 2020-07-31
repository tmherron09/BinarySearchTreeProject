using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeClass
{
    [DebuggerDisplay("{(Root != null ? \"Root Key: \" + Root.key.ToString() : \"No Root Node\")}")]
    public class BinarySearchTree
    {
        public Node Root;


        public void AddNode(Node nodeToAdd)
        {
            if (Root == null)
            {
                Root = nodeToAdd;
            }
            else if (Root.key == nodeToAdd.key)
            {
                //throw new Exception();
                Console.WriteLine("Node not added. All Keys must be Unique");
                return;
            }
            else
            {
                AddNode(nodeToAdd, Root);
            }
        }
        public void AddNode(Node nodeToAdd, Node currentNode)
        {
            if (nodeToAdd.key < currentNode.key)
            {
                if (currentNode.leftNode == null)
                {
                    currentNode.leftNode = nodeToAdd;
                    return;
                }
                AddNode(nodeToAdd, currentNode.leftNode);
            }
            else if (nodeToAdd.key > currentNode.key)
            {
                if (currentNode.rightNode == null)
                {
                    currentNode.rightNode = nodeToAdd;
                    return;
                }
                AddNode(nodeToAdd, currentNode.rightNode);
            }
            else
            {
                //throw new Exception();
                Console.WriteLine("Node not added. All Keys must be Unique");
            }
        }
        public Node Search(Node nodeToSearch)
        {
            if (Root.key == nodeToSearch.key)
            {
                return Root;
            }
            Node nextNode = Root.key > nodeToSearch.key ? Root.leftNode : Root.rightNode;
            return Search(nodeToSearch.key, nextNode);
        }
        public Node Search(int key)
        {
            if (Root.key == key)
            {
                return Root;
            }
            Node nextNode = Root.key > key ? Root.leftNode : Root.rightNode;
            return Search(key, nextNode);
        }
        public Node Search(int key, Node nextNode)
        {

            if (nextNode.key == key)
            {
                return nextNode;
            }
            nextNode = nextNode.key > key ? nextNode.leftNode : nextNode.rightNode;
            if (nextNode == null)
            {
                // BST does not contain Node.
                return null;
            }
            return Search(key, nextNode);
        }
    }
}
