
using System.Collections.Concurrent;
using System.Data;

namespace PLCS
{
    public class ParkingLotControlSystem
    {
        private readonly object _entryGuard = new object();
        private readonly object _exitGuard = new object();

        Random rng = new Random();

        private List<int> _parkingSpace = new List<int>();

        public ParkingLotControlSystem() { }

        public void EnterParkingLot (int carPlate)
        {
            while (_parkingSpace.Count > 5)
            {
                Thread.Sleep(1000);
            }
            lock(_entryGuard) 
            {
                Console.WriteLine($"Car {carPlate} has entered the parking lot");
                _parkingSpace.Add(carPlate);
            }
            Thread.Sleep(rng.Next(1000, 10000));
            ExitParkingLot(carPlate);
        }

        private void ExitParkingLot (int carPlate)
        {
            lock(_exitGuard)
            {
                Console.WriteLine($"Car {carPlate} has exited the parking lot");
                _parkingSpace.Remove(carPlate);
            }
            Thread.Sleep(rng.Next(1000, 10000));
        }
    }
}
