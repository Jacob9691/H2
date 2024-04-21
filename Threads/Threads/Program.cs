using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning about threads");
            Console.WriteLine();

            Console.WriteLine("Main: Creating threads");
            //HalloFromThread halloFromThread1 = new (1);
            //HalloFromThread halloFromThread2 = new (2);
            //Task taks1 = Task.Run(() => halloFromThread1.ThreadHallos());
            //Task taks2 = Task.Run(() => halloFromThread2.ThreadHallos
            //Task.WaitAll(taks1, taks2);

            //SharingIsCaring share = new ();
            //Task taskAdd = Task.Run(() => share.Add());
            //Task taskRead = Task.Run(() => share.Read());
            //Console.WriteLine("Main: Waiting for threads to finish");
            //Task.WaitAll(taskAdd, taskRead);
            Console.WriteLine("Write a number of tasks between 1-100");
            int tasks = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Write how many milliseconds a thrad should sleep");
            int sleep = int.Parse(Console.ReadLine()!);
            
            Vector vector = new Vector();
            for (int i = 1; i <= tasks; i++)
            {
                try
                {
                    Task<bool> writerTask = Task<bool>.Run(() => vector.SetAndTest(i));

                    if (writerTask.Result)
                    {
                        Console.WriteLine($"Writer {i}: All is good");
                    }
                    else
                    {
                        Console.WriteLine($"Writer {i}: All is bad");
                    }

                    Thread.Sleep(sleep);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in Writer {i}: {ex.Message}");
                }      
            }

            Console.WriteLine("Main: Exiting");
        }

        /*
         Task notes Pro 5.1:
            Exercise 1 Creating Threads:
            - if main return immediately after creating the threads, it well print out the last line,
                before the threads have ended. So when it says the program is finished,
                it isn't true, since the threads are still running.
            Exercise 2 Sharing data between threads
            - The problem of just letting the two threads add and reas, is that they are not waiting for each other.
                So the read thread can read share two times before the add thread adds on the share value. 
                This can be fixed by putting in a lock in the two methods. Then they have to wait for each other,
                since only one thread can be in the lock.
            Exercise 3: Sharing a Vector Class Between Threads
            - 
         */
    }
}
