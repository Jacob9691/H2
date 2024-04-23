using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class Vector
    {
        private int[] vector;
        private int size;

        //static Mutex myMutex = new Mutex();
        //static Semaphore mySemaphore = new Semaphore(2, 2);
        private readonly Mutex _resourceMutex = new Mutex();

        public Vector()
        {
            size = 10000;
            vector = new int[size];
            Set(0);
        }

        public bool SetAndTest(int n)
        {
            //myMutex.WaitOne();
            //try
            //{
            //    Set(n);
            //    return Test(n);
            //}
            //finally
            //{
            //    myMutex.ReleaseMutex();
            //}

            //mySemaphore.WaitOne();
            //try
            //{
            //    Set(n);
            //    return Test(n);
            //}
            //finally
            //{
            //    mySemaphore.Release();
            //}

            using (var scopedLocker = new ScopedLocker(_resourceMutex))
            {
                Set(n);
                return Test(n);
            }
        }

        private void Set(int n)
        {
            for (int i = 0; i < size; i++)
            {
                vector[i] = n;
            }
        }

        private bool Test(int n)
        {
            for (int i = 0; i < size; i++)
            {
                if (vector[i] != n)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
