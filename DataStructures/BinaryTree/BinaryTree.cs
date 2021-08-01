using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        public BinaryTree()
        {
            _root = null;
        }

        private Node _root;

        public void Insert(int data)
        {
            if (_root is null)
            {
                _root = new Node(data);
                Console.WriteLine($"{data} is root node");

                return;
            }

            var newNode = new Node(data);
            Insert(_root, newNode);
        }

        private void Insert(Node root, Node newNode)
        {
            root ??= newNode;

            if (newNode.Data < root.Data)
            {
                if (root.LeftNode is null)
                {
                    root.LeftNode = newNode;
                    Console.WriteLine($"{newNode.Data} is left node of {root.Data} node");
                }
                else
                {
                    Console.WriteLine($"{newNode.Data} going deep into left node: {root.LeftNode.Data}");
                    Insert(root.LeftNode, newNode);
                }
            }
            else
            {
                if (root.RightNode is null)
                {
                    root.RightNode = newNode;
                    Console.WriteLine($"{newNode.Data} is right node of {root.Data} node");
                }
                else
                {
                    Console.WriteLine($"{newNode.Data} going deep into right node: {root.RightNode.Data}");
                    Insert(root.RightNode, newNode);
                }
            }
        }

        public int GetTotalNodes()
        {
            return GetTotalNodes(_root);
        }

        private int GetTotalNodes(Node node)
        {
            if (node is null) return 0;

            return 1 + GetTotalNodes(node.RightNode) + GetTotalNodes(node.LeftNode);
        }
    }

    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public int Data { get; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }

        public Node()
        {
        }
    }
}