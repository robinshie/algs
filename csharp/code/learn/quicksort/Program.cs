using System;
using System.Linq;
namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[]{3,4,1,5,2};
            quicksortMethod(A,0,A.Count()-1);
            foreach (var item in A)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void quicksortMethod(int[] A, int start, int end)
        {
            System.Console.WriteLine($"start:{start},end:{end}");
            if(start>=end)
            {
                return;
            }
            int pivol = A[(start+end)/2];
            System.Console.WriteLine($"pivol:{pivol}");
            int left = start;int right = end;
            while(left<right) //start 和end 部分不能有交集
            {
                
            System.Console.WriteLine($"left：{left},right：{right}");
                while (left<right && A[left]<pivol)
                {
                    left++;
                }
                while (left<right && A[right] > pivol)
                {
                    right--;
                }
                if(left<right)
                {
                    int temp= A[right];
                    A[right] = A[left];
                    A[left] = temp;
                    left++;
                    right--;
                }

            }
            quicksortMethod(A,start,right);
            quicksortMethod(A,left,end);
        }
    }
}
