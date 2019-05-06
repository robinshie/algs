//
// Created by robin on 19-4-24.
//
#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <math.h>
template <class T>
int getArrayLen(T& array)
{
    return (sizeof(array) / sizeof(array[0]));
}
typedef struct
{
    int left_max;
    int right_max;
    double sum;
} result;

result find_crossing_subarray(int A[], int low, int mid,int high)
{
    result r;
    int leftsum=-999999;
    int max_left = 0;
    int sum = 0;
    for (int i = mid; i >= 0; i--) {
        sum+=A[i];
        if(sum > leftsum){
            leftsum=sum;
            max_left = i;
        }
    }
    int rightsum=-999999;
    int max_right;
    sum = 0;
    for (int j = mid+1; j < high; ++j) {
        sum += A[j];
        if(sum>rightsum)
        {
            rightsum = sum;
            max_right = j;
        }
    }

    r.left_max=max_left;
    r.right_max = max_right;
    r.sum = leftsum+rightsum;

    return r;

}

result find_max_subarray(int A[], int low, int high)
{
    result rleft;
    result rright;
    result rcross;
    result r;
    if(high == low)
    {
        r.left_max = low,
        r.right_max = high,
        r.sum = A[low];
        return  r;
    }
    int mid;
    mid = floor((high + low) / 2) ;

    rleft=find_max_subarray(A,low,mid);
    rright=find_max_subarray(A,mid+1,high);
    rcross = find_crossing_subarray(A,low,mid,high);

    if(rleft.sum>=rright.sum && rleft.sum >= rcross.sum)
    {
        return rleft;
    } else if (rright.sum>=rleft.sum && rright.sum>=rcross.sum )
    {
        return  rright;
    } else {
        return  rcross;
    }


}


int main()
{
    result r;
    int a[] = {13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7};
    r = find_max_subarray(a,0,16);
    std::cout<<r.sum<<","<<r.left_max<<","<<r.right_max<<","<<std::endl;

}