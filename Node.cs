using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeClass
{
    [DebuggerDisplay("Key: {key}  | Left Node: {(leftNode != null ? leftNode.key.ToString() : \"Empty\")} | Right: {(rightNode != null ? rightNode.key.ToString() : \"Empty\")}")]
    public class Node
    {
        public int key;
        public string data;
        public Node leftNode;
        public Node rightNode;

        public Node(int key)
        {
            this.key = key;
            data = "Empty Node";
        }
        public Node(int key, string data)
        {
            this.key = key;
            this.data = data;
        }

        public override string ToString()
        {
            return $"Node Key: {key}    Value: {data}";
        }
    }
}
