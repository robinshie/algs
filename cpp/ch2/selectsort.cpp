//
// Created by robin on 19-4-24.
//
#include <stdio.h>
#include <stdlib.h>
#include <iostream>
template <class T>
int getArrayLen(T& array)
{
    return (sizeof(array) / sizeof(array[0]));
}

int main()
{
    int arr[] = {77,56,23,21,66};
    int arrlen = getArrayLen(arr);

    for (int i = 1; i < arrlen; ++i) {
        int key = arr[i];
        int j;
        j = i-1;
        while (j>-1&&arr[j]<key)
        {
            arr[j+1]=arr[j];
            j--;
        }
        arr[j+1] = key;
    }

    for (int k = 0; k < arrlen; ++k) {
        printf("%d ",arr[k]);
    }
}