using System;
using System.Collections.Generic;

namespace bintreeleveltravel
{
    public class Node
    {
        public int value;
        public Node leftTree;
        public Node rightTree;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node()
            {
                 value = 1,

                 leftTree = new Node()
                 {
                     value = 2
                 },
                 rightTree = new Node()
                 {
                     value = 3
                 }
            };
            List<int> result = LevelTravel(root);
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }

        private static List<int> LevelTravel(Node root)
        {
            List<int> result = new List<int>();
            Queue<Node> tree = new Queue<Node>(); 
            tree.Enqueue(root);
            while (tree.Count != 0)
            {
                List<int> levelresult = new List<int>();
                int size = tree.Count;
                for (int i =0;i<size;i++)
                {
                    var item = tree.Dequeue();
                    levelresult.Add(item.value);
                    if(item.leftTree!=null)
                    {
                        tree.Enqueue(item.leftTree);
                    }
                    if(item.leftTree!=null)
                    {
                        tree.Enqueue(item.rightTree);
                    }

                }
                result.AddRange(levelresult);
            }
            return result;

        }
    }
}
