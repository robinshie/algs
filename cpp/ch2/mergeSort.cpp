#include<iostream>
using namespace std;

void merge_sort(int a[], int p, int r);
void merge(int a[], int p, int q, int r);

int main()
{
    int a[] = {24, 1, 3, 67, 4, 24, 41, 234};
    merge_sort(a, 0, 7);

    for(int i = 0; i < 8; ++i)
    {
        cout<<a[i]<<" ";
    }
}

void merge_sort(int a[], int p, int r)
{
    if(p<r) {
        int  q = (p + r) / 2;
        merge_sort(a,p,q);
        merge_sort(a,q+1,r);
        merge(a,p,q,r);
    }

}

void merge(int a[], int p, int q, int r) {

    int lenl = q - p + 1;
    int lenr = r - q;

    int arrL[lenl];
    int arrr[lenr];

    for (int i = 0; i < lenl; ++i) {
        arrL[i] = a[p + i];
    }
    for (int j = 0; j < lenr; ++j) {
        arrr[j] = a[q + 1 + j ];
    }

    int i = 0;
    int j = 0;
    int k = p;
    while (i < lenl && j < lenr) {
        if (arrL[i] <= arrr[j]) {
            a[k] = arrL[i];
            i++;
        } else {
            a[k] = arrr[j];
            j++;
        }
        k++;
    }
    if (i == lenl) {
        for (int u = j; u < lenr; ++u) {
            a[k++] = arrr[u];
        }
    } else {
        for (int l = i; l < lenl; ++l) {
            a[k++] = arrL[l];
        }
    }

}