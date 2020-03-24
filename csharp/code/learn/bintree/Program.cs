using System;
///
//Balanced Binary Tree 
///
namespace bintree
{
    public class Tree
    {
        public int Value{get;set;}
        public Tree LeftTree{get;set;}
        public Tree RightTree{get;set;}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree()
            {
                Value = 0,
                LeftTree = new Tree()
                {
                    Value = 1
                },
                RightTree = new Tree()
                {
                    Value = 2,
                    LeftTree=new Tree
                    {
                        Value = 3,
                       
                    }
                }
            };
           System.Console.WriteLine(IsBinTree(tree));
        }
        static bool IsBinTree(Tree root)
        {
            return MaxDeepDiff(root)!=-1;

        }
        private static int MaxDeepDiff(Tree root)
        {
            if(root == null)
            {
                return 0;
            }
            int leftdeep = MaxDeepDiff(root.LeftTree);
            
            int rightdeep = MaxDeepDiff(root.RightTree);
            if(leftdeep==-1||rightdeep==-1||
            Math.Abs(leftdeep-rightdeep)>1)
            {
                return -1;
            }
            return Math.Max(rightdeep,leftdeep)+1;
        }
    }
}
