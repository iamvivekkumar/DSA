using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    static class Sort
    {
        static public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        static public int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (arr[i] != arr[min])
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            return arr;
        }

        static public int[] InsertionSort(int[] arr)
        {
            //best for nearly sorted array
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            return arr;
        }

        static public int[] MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                MergeSortMergeArray(arr, left, mid, right);
            }

            return arr;
        }

        static public void MergeSortMergeArray(int[] arr, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left; //new array index

            int[] newArr = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    newArr[k] = arr[i];
                    i++;
                }
                else
                {
                    newArr[k] = arr[j];
                    j++;
                }
                k++;
            }

            if (i > mid)
            {
                while (j <= right)
                {
                    newArr[k] = arr[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i <= mid)
                {
                    newArr[k] = arr[i];
                    i++;
                    k++;
                }
            }

            for (k = left; k <= right; k++)
            {
                arr[k] = newArr[k];
            }

        }

        static public int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotPos = QuickSortPartition(arr, left, right);
                QuickSort(arr, left, pivotPos - 1);
                QuickSort(arr, pivotPos + 1, right);
            }

            return arr;
        }

        static public int QuickSortPartition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int i = left;
            int j = right;

            while (arr[i] < arr[j])
            {
                while (arr[i] <= pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    SwapNumbers(arr, i, j);
                }
            }

            SwapNumbers(arr, left, j);

            return j;
        }

        static void SwapNumbers(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}