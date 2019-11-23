using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsSuggestionGenerator
{
    public class Node
    {
        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(string data)
        {
            this.Data = data;

        }
    }
    public class BinaryTree
    {
        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(string data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }
            InsertRecursive(Root, new Node(data));
        }
        private void InsertRecursive(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (string.Compare(newNode.Data , root.Data) < 0)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRecursive(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRecursive(root.Right, newNode);
            }
        }
    }
    
}
