using System;
using System.Collections.Generic;

namespace bintreeperorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root= new Node()
            {
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
            List<int > result = new List<int>();
            result=PerorderHelper.PerOrderDivideConter(root);
             foreach (var item in result)
             {
                 System.Console.WriteLine(item);
             }

        }
    }
}
