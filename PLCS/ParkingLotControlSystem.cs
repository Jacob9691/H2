
using System.Collections.Concurrent;
using System.Data;

namespace PLCS
{
    public class ParkingLotControlSystem
    {
        private readonly object _entryGuard = new object();
        private readonly object _exitGuard = new object();

        Random rng = new Random();

        private static readonly ConcurrentQueue<int> ParkingSpace = new ConcurrentQueue<int>();

        public ParkingLotControlSystem() { }

        public async void EnterParkingLot (int carPlate)
        {
            RequestEntryPermission(carPlate);
            Thread.Sleep(rng.Next(1000, 10000));
            ExitParkingLot(carPlate);
            await Task.Delay(25);
        }

        private void RequestEntryPermission(int carPlate) 
        {
            while (true)
            {
                int itemCount;
                lock (_entryGuard)
                {
                    itemCount = ParkingSpace.Count;

                    if (itemCount <= 1)
                    {
                        ParkingSpace.Enqueue(carPlate);
                        Console.WriteLine($"Car {carPlate} has entered the parking lot");
                        break;
                    }
                }

                Thread.Sleep(50);
            }
        }

        private void ExitParkingLot (int carPlate)
        {
            lock(_exitGuard)
            {
                if (ParkingSpace.TryDequeue(out carPlate))
                {
                    Console.WriteLine($"Car {carPlate} has exited the parking lot");
                }
                else
                {
                    Console.WriteLine($"Error: car {carPlate} couldn't be found in queue");
                }
            }
        }
    }
}
