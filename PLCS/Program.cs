using PLCS;

ParkingLotControlSystem PLCS = new();
List<Car> cars = new List<Car>
{
    new(1),
    new(2),
    new(3),
    new(4),
    new(5),
    new(6),
    new(7),
    new(8),
    new(9),
    new(10)
};

try
{
    for (int i = 0; i < 5; i++)
    {
        foreach (Car car in cars)
        {
            try
            {
                Thread.Sleep(1000);
                ThreadPool.QueueUserWorkItem(_ => PLCS.EnterParkingLot(car.CarPlate));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error with car {car.CarPlate}: " + ex.ToString());
            }
        }    
    }

    Console.WriteLine("The parking lot is now closed for today...");
    Console.ReadLine();
}
catch (Exception ex)
{
    throw new Exception($"Error: {ex}");
}
