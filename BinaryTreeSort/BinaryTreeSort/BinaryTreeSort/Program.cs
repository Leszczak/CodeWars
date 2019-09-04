using System;
using System.Collections.Generic;

class Kata
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }

    public static List<int> TreeByLevels(Node node)
    {
        if (node == null)
            return new List<int>();

        List<Node> nodes = new List<Node>();
        List<int> result = new List<int>();
        Stack<Node> lastNodes = new Stack<Node>();

        Node originalNode = node;
        Node currentNode = node;
        while (true)
        {
            if(currentNode.Left != null 
                && !nodes.Contains(currentNode.Left))
            {
                lastNodes.Push(currentNode);
                currentNode = currentNode.Left;
                continue;
            }
            if (currentNode.Right != null
                && !nodes.Contains(currentNode.Right))
            {
                lastNodes.Push(currentNode);
                currentNode = currentNode.Right;
                continue;
            }
            if(lastNodes.Count!=0)
            {
                nodes.Add(currentNode);
                currentNode = lastNodes.Pop();
                continue;
            }
            nodes.Add(currentNode);
            break;
        }
        foreach (Node n in nodes)
            Console.Write(n.Value + " ");

        return null;
    }
}