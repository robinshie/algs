//
// Created by robin on 19-5-7.
//

#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#define Left(x) (x << 1)
#define Right(x) ((x << 1) + 1)
template <class T>
int getArrayLen(T& array)
{
    return sizeof(array) / sizeof(array[0]);
}
void swap(int *a,int *b) {
    int temp=*a;
    *a=*b;
    *b=temp;
}
void  printArray(int arr[],int lenth)
{
    for (int i = 0; i < lenth; ++i) {
        printf("%d,",arr[i]);
    }
}
void heapsort(int arr[],int len);


int main()
{
    int a[] = {16, 14, 10, 8, 7, 9, 3, 2, 4, 1};
    int lenth = getArrayLen(a);
    printArray(a,lenth);
    printf("\r\n");
    heapsort(a,lenth);
    printArray(a,lenth);

}

void maxheapify(int arr[], int i, int heapsize)
{
    int l = Left(i)+1;
    int r = Right(i)+1;

    int maxIndex=i;

    if(l<=heapsize && arr[l] > arr[i])
    {
        maxIndex = l;
    }
    if(r<=heapsize && arr[r]>arr[maxIndex])
    {
        maxIndex = r;
    }
    if(maxIndex != i)
    {
        swap(&arr[i],&arr[maxIndex]);
        maxheapify(arr,maxIndex,heapsize);
    }

}
void buildMaxHeap(int arr[],int heapsize)
{
    int start = (heapsize-1)/2;
    for (int i = start ;i >=0 ; i--) {
        maxheapify(arr,i,heapsize);
    }
}

void heapsort(int arr[],int len)
{
    buildMaxHeap(arr,len-1);
    int heapsize = len-1;
    for (int i = len-1; i > 0 ; i--) {
        swap(&arr[0],&arr[i]);
        heapsize = heapsize-1;
        maxheapify(arr,0,heapsize);
    }

}