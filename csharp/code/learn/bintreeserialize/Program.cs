using System;

namespace bintreeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node()
            {
                value = 2,
                leftTree = new Node()
                {
                    value = 1 ,
                    leftTree = new Node()
                    {
                        value =4
                    }   
                },
                rightTree = new Node()
                {
                    value = 3,
                    leftTree = new Node()
                    {
                        value =6
                    }  
                }
            };
            var st= SerializeHelper.Serialize(root);
            var dest = SerializeHelper.DeSerialize(st);
            
            Console.WriteLine(st);
        }


    }
}
