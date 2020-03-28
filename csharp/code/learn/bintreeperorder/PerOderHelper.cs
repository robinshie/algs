using System;
using System.Collections.Generic;
using System.Linq;
namespace bintreeperorder {
   public class Node {
        public   int value;
       public Node leftNode;
        public Node rightNode;
        
    }
    public static class PerorderHelper
    {
        public  static List<int> PerOrderNotRecursion(Node root )
        {
            List<int> result = new List<int>();
            Stack<Node> stack = new Stack<Node>();

            stack.Push(root);
            
            while (stack.Count()!=0)
            {
                var top = stack.Pop();
                result.Add(top.value);
                if(top.rightNode!=null)
                {
                    stack.Push(top.rightNode);
                }
                if(top.leftNode!=null)
                {
                    stack.Push(top.leftNode);
                }
                
            }
            return result;
        }
        public  static void PerOrderRecursion(Node root,List<int> result )
        {
            if(root==null)
            {
                return;
            }
            result.Add(root.value);
            PerOrderRecursion(root.leftNode,result);
            PerOrderRecursion(root.rightNode,result);
        }
        public  static List<int> PerOrderDivideConter(Node root)
        {
            List<int> result  = new List<int>();
            if(root==null)
            {
                return result;
            }

            var leftvalue = PerOrderDivideConter(root.leftNode);

            var rightvalue = PerOrderDivideConter(root.rightNode);

            result.Add(root.value);
            result.AddRange(leftvalue);
            result.AddRange(rightvalue);

            return result;
        }
        
    }
}