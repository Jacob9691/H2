

using System.Diagnostics;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            RandomArrayGenerator generator = new RandomArrayGenerator();

            // Generate random arrays of different sizes
            int[] reallyBigArray = generator.GenerateRandomArray(20000);
            int[] arrThousand = generator.GenerateRandomArray(1000);

            // Test different sorting algorithms
            Console.WriteLine("Start Sorting");
            
            TestSortingAlgorithm.RunSortingAlgorithm("MergeSort", MergeSort.Sort, reallyBigArray);
            generator.ShuffleArray(reallyBigArray);
            Console.WriteLine("Start Sorting");
            TestSortingAlgorithm.RunSortingAlgorithm("ParallelMergeSort", ParallelMergeSort.Sort, arrThousand);
            Console.WriteLine("Start Sorting");
            TestSortingAlgorithm.RunSortingAlgorithm("ThresholdParallelMergeSort", ThresholdParallelMergeSort.Sort, arrThousand);
            generator.ShuffleArray(reallyBigArray);
            Console.WriteLine("Start Sorting");
            TestSortingAlgorithm.RunSortingAlgorithm("ThreadPoolParallelMergeSort", ThreadpoolParallelMergeSort.Sort, reallyBigArray);

            /* 
             Task notes:
                Exercise 1 Run the program:
                - The program generates two arrays that is used to showcase a merge sort and a parallel merge sort.
                - The merge sort cuts the array in two halfs, then sorts and merges them together. 
                    And it keeps going untill the whole arrays is sorted. The parallel merge sort is the same,
                    but instead it keeps making threads for each cut in the array. Having threads dividing the work,
                    should make the sorting faster. But when it's a large arry, it could end up making too many threads.
                - It seems merge sorting is way faster. But this really depends on the processor, since 
                    parallel merge sorting's threadting can speed up the sorting. But just normal merge sort is the
                    faster choice if the processor isn't as strong.
                - The merge sorting doesn't generate many threads, but when the program gets to parallel merge sort,
                    the program can get over 1400 threads. And that's because it keeps making new threads when the sorting
                    is happening.
                Exercise 2 Implement ThresholdParallelMergeSort:
                - By adding a threshold, the sorting can start with a normal merge sort, to cut the array into smaller
                    pieace for the parallel merge sort. Therefore there for be a need for as many threads, and it gets faster
                    with the threshold.
                Exercise 3: Implement ThreadpoolParallelMergeSort:
                - By giving the sorting a threadpool, it can better manage the threads it creates under sorting.
                    It reuses threads when it's done with them, so the program won't keep open and close new threads.
                    This actually improves the sorting a lot, since it doesn't put as much stress on my CPU.
                    And add a threshold only makes it faster. One problem there could be with a threadpool,
                    is that it is possible to run out of threads, if there aren't enough threads in the threadpool.
            */
        }
    }
}