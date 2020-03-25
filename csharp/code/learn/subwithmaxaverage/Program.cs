using System;

namespace subwithmaxaverage
{
    public class Node
    {
       public int value;
       public Node leftNode;
       public Node rightNode;

    }
    public class ResultVale
    {
        public ResultVale(int sum,int size)
        {
            this.sum = sum;
            this.size =size;
            
        }
        public int sum;
        public int size;


    }
    class Program
    {
        static Node maxavgTree;
        
        static ResultVale maxresult;
        static void Main(string[] args)
        {
            //maxavgTree = new Node();
            Node root= new Node() {
                value = 1,
                leftNode = new Node()
                {
                    value = 2
                },
                rightNode = new Node()
                {
                    value = 3
                }
            };
            SubavgMethod(root);

            Console.WriteLine(maxavgTree.value);
        }
        static Node GetResult(Node root)
        {
            SubavgMethod(root);
            return maxavgTree;
        }

        private static ResultVale SubavgMethod(Node root)
        {
            if(root==null)
            {
                return new ResultVale(0,0);
            }

            var leftresutl = SubavgMethod(root.leftNode);
            
            var rightresutl = SubavgMethod(root.rightNode);

            var rootresult = new ResultVale(leftresutl.sum+rightresutl.sum+root.value,
             leftresutl.size + rightresutl.size + 1
            );

            if(maxavgTree==null ||
            maxresult.sum * rootresult.size < rootresult.sum*maxresult.size
            )
            {
                maxavgTree = root;
                maxresult = rootresult;
            }
            return rootresult;
        }
    }
}
