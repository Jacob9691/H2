using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class ThreadpoolParallelMergeSort
    {
        private const int Threshold = 0; // Adjust the threshold size as needed

        public static void Sort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int left, int right)
        {
            // Implement a multi-threaded version of MergeSort by using Threadpool
            // This implementaion should us the Threshold variable to set a minimum size for the left/right array
            // Where we want to still create a new thread, when size is below
            // We want to do a SequentialMergeSort
            throw new NotImplementedException();
        }

        private static void SequentialMergeSort(int[] arr, int left, int right)
        {
            // Implement a single-threaded version of MergeSort
            // This could be the same as in your original MergeSort implementation
            throw new NotImplementedException();
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Implement the merge logic
            // This is similar to your original Merge method
            throw new NotImplementedException();

        }
    }
}
