using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class RandomArrayGenerator
    {
        private Random random;

        public RandomArrayGenerator()
        {
            random = new Random();
        }

        public int[] GenerateRandomArray(int length)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next();
            }

            return arr;
        }

        public void ShuffleArray<T>(T[] arr)
        {
            // random.Shuffle(arr); can't use this because I only have .net 6

            int n = arr.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                T temp = arr[n];
                arr[n] = arr[k];
                arr[k] = temp;
            }
        }

    }
}
