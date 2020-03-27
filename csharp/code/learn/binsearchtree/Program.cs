using System;

namespace binsearchtree
{
    public class ResultType
    {
        public ResultType(bool isbinstree,int max,int min)
        {
            this.isbinstree = isbinstree;
            minvalue = min;
            maxvalue = max;
            
        }
        public bool isbinstree;
        public int maxvalue;
        public int minvalue;
    }
    public class Tree
    {
        public int Value;
        public Tree LeftTree;
        public Tree RightTree;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree root = new Tree()
            {
                Value = 1,
                LeftTree = new Tree()
                {
                    Value = 2
                },
                RightTree = new Tree()
                {
                    Value = 3
                }
            };
            System.Console.WriteLine(isBinSearchTree(root));
            Console.WriteLine("Hello World!");
        }
        static bool isBinSearchTree(Tree root)
        {
            bool result = false;
            result = Cal(root).isbinstree;
            return result;
        }
        private static ResultType Cal(Tree root)
        {
            if(root==null)
            {
                return new ResultType(true,-9999,9999);
            }
            if(root.LeftTree==null && root.RightTree==null)
            {
                return new ResultType(true,root.Value,root.Value);
            }
            ResultType leftresult = Cal(root.LeftTree);
            
            ResultType rightresult = Cal(root.RightTree);
            
            bool leftisbst = root.LeftTree==null|| root.Value>leftresult.maxvalue && leftresult.isbinstree;
            
            bool rightisbst = root.RightTree==null|| root.Value<=rightresult.minvalue && rightresult.isbinstree;
            var resultv = rightisbst && leftisbst;
            
            if(resultv)
            {
                var temp = new ResultType(true,0,0);
                temp.minvalue = root.LeftTree ==null?root.Value:leftresult.minvalue;
                temp.maxvalue= root.RightTree ==null?root.Value:rightresult.maxvalue;
                return temp;
            }
            return new ResultType(false,0,0);

        }
    }
}
