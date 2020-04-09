using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace bintreeserialize {
    public class Node {
        public int value;
        public Node leftTree;
        public Node rightTree;
    }

    public class SerializeHelper {
        public static string Serialize (Node root) {
            if (root == null) {
                return "{}";
            }
            List<Node> queue = new List<Node>();
            queue.Add(root);
            for (int i = 0; i <queue.Count ; i++)
            {
                var currentnode = queue[i];
                if(currentnode==null)
                {
                    continue;
                }
                queue.Add(currentnode.leftTree);
                
                queue.Add(currentnode.rightTree);                
            }
            // 剪枝
            while(queue[queue.Count-1] == null)
            {
                queue.RemoveAt(queue.Count-1);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(queue[0].value);
            for (int i = 1; i < queue.Count; i++)
            {
                if(queue[i]==null)
                {
                    sb.Append(",#");
                }else
                {
                    sb.Append(",");
                    sb.Append(queue[i].value);
                }
            }
            sb.Append("]");
            return sb.ToString();
            
        }
        public static Node DeSerialize (string source) {
            if(string.IsNullOrEmpty(source))
            {
                return null;
            }
            var nodes = source.Substring(1,source.Length-2).Split(",");
            List<Node> queue = new List<Node>();
            var root =new Node(){value = int.Parse(nodes[0]) };
            queue.Add(root);
            for (int i = 1; i < nodes.Length; i++)
            {
                var node = nodes[i];
                int index = (i-1)/2;
                if(node!="#")
                {
                    Node node1 = new Node();
                    node1.value = int.Parse(node);
                    if(i%2!=0)
                    {
                        queue[index].leftTree= node1;
                    }
                    else 
                    {
                        queue[index].rightTree= node1;
                    }

                    queue.Add(node1);
                }
            }
            
            return root;
        }

    }
}