using System;

namespace GraphValidTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var eages = new int[][]{
                  new int[] { 0,1},
                  new int[] { 1,2 },
                  new int[] { 2,0 }
              };
            Console.WriteLine(GraphValidTreeHelper.ValidTree(5,eages));
        }
    }
}
