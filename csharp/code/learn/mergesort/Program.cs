using System;

namespace test
{
    class Program
    { 
        static int count=0;
        static void Main(string[] args)
        {
            int[] A = new int[]{8,7,6,5,4,3,2,1};
            int[] temp = new int[A.Length];

            MeragedSort(A,0,A.Length-1,temp);
            System.Console.WriteLine(count);
            foreach(var i in A)
            {
                Console.Write(i+",");
            }
        }

        private static void MeragedSort(int[] A, int start, int end, int[] temp)
        {
            System.Console.WriteLine(start+"->"+end);
            if(start>=end)
            {
                return;
            }
            int mid = (start+end)/2;
            MeragedSort(A,start,mid,temp);
            MeragedSort(A,mid+1,end,temp);
            Merage(A,start,end,temp);

        }

        private static void Merage(int[] A, int start, int end, int[] temp)
        {
            int mid =  (start+end)/2;
            count++;
            int leftStart = start;
            int rightStart = mid+1;
            int index = leftStart;
            while(leftStart<=mid && rightStart<=end)
            {
                if(A[leftStart]<=A[rightStart])
                {
                    temp[index++]=A[leftStart++];
                }
                else
                {
                    temp[index++]=A[rightStart++];
                }
            }
            while (leftStart<=mid)
            {
                temp[index++]=A[leftStart++];
            }
            while (rightStart<=end)
            {
                temp[index++]=A[rightStart++];
            }

            for (int i = start; i <= end; i++)
            {
                A[i] = temp[i];
            }
        
        }
    }
}
