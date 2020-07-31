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
            else
            {
                AddNode(nodeToAdd, Root);
            }
        }
        public void AddNode(Node nodeToAdd, Node currentNode)
        {
            
            if (nodeToAdd.key <= currentNode.key)
            {
                if (currentNode.leftNode == null)
                {
                    currentNode.leftNode = nodeToAdd;
                    return;
                }
                AddNode(nodeToAdd, currentNode.leftNode);
            }
            else
            {
                if (currentNode.rightNode == null)
                {
                    currentNode.rightNode = nodeToAdd;
                    return;
                }
                AddNode(nodeToAdd, currentNode.rightNode);
            }
        }

    }
}
