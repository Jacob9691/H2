using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class ThresholdParallelMergeSort
    {
        private const int Threshold = 100; // Adjust the threshold size as needed

        public static void Sort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            Sort(arr, 0, arr.Length - 1);
        }

        
        private static void Sort(int[] arr, int left, int right)
        {
            // Implement a multi-threaded version of MergeSort
            // This implementaion should us the Threshold variable to set a minimum size for the left/right array
            // Where we want to still create a new thread, when size is below
            // We want to do a SequentialMergeSort
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Create threads for sorting left and right halves
                Thread leftThread = new Thread(() => Sort(arr, left, mid));
                Thread rightThread = new Thread(() => Sort(arr, mid + 1, right));

                // Start the threads
                if (left > Threshold)
                {
                    leftThread.Start();
                }
                else
                {
                    SequentialMergeSort(arr, left, mid);
                }

                if (right > Threshold)
                {
                    rightThread.Start();
                }
                else
                {
                    SequentialMergeSort(arr, mid + 1, right);
                }


                // Join the threads to wait for them to finish
                if (left > Threshold)
                    leftThread.Join();
                
                if (right > Threshold)
                    rightThread.Join();

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        private static void SequentialMergeSort(int[] arr, int left, int right)
        {
            // Implement a single-threaded version of MergeSort
            // This could be the same as in your original MergeSort implementation
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Sort left and right halves recursively
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Implement the merge logic
            // This is similar to your original Merge method
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            // Copy data to temp arrays
            for (int i = 0; i < n1; ++i)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; ++j)
                rightArr[j] = arr[mid + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first and second subarrays
            int iLeft = 0, iRight = 0;

            // Initial index of merged subarray array
            int k = left;
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                {
                    arr[k] = leftArr[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArr[iRight];
                    iRight++;
                }
                k++;
            }

            // Copy remaining elements of leftArr[] if any
            while (iLeft < n1)
            {
                arr[k] = leftArr[iLeft];
                iLeft++;
                k++;
            }

            // Copy remaining elements of rightArr[] if any
            while (iRight < n2)
            {
                arr[k] = rightArr[iRight];
                iRight++;
                k++;
            }

        }
    }
}
