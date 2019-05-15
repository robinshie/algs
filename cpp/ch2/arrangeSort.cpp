//
// Created by robin on 19-5-15.
//

#include <stdio.h>
#include <stdlib.h>
#include <iostream>
template <class T>
int getArrayLen(T& array)
{
    return sizeof(array) / sizeof(array[0]);
}
void  printArray(int arr[],int lenth)
{
    for (int i = 0; i < lenth; ++i) {
        printf("%d,",arr[i]);
    }
}
void arrangesort(int arr[],int len);


int main()
{
    int a[] = {7, 4, 2, 1, 5, 3, 1, 5};
    int lenth = getArrayLen(a);
    printArray(a,lenth);
    printf("\r\n");
    arrangesort(a,lenth);
}
void arrangesort(int arr[],int len)
{
    int b[len+1] = {0};
    for (int i = 0; i < len+1; ++i) {
        if(i<len)
        {
            b[arr[i]]++;
        } else {
            b[i] = 0;
        }
    }
    for (int j = 1; j <= len+1; ++j) {
        b[j] += b[j-1];
    }
    printArray(b,len+1);
    printf("\r\n");
    int c[len] = {0};
    for (int k = len; k >= 1; --k) {
        c[(b[arr[k-1]]-1)] = arr[k-1];
        b[arr[k-1]]--;
    }

    printArray(c,len);
}