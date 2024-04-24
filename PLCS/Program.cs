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
List<Task> tasks = new List<Task>(); 

try
{
    foreach (Car car in cars)
    {
        try
        { 
            tasks.Add(Task.Run(() =>
            {
                PLCS.EnterParkingLot(car.CarPlate);
            }));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with car {car.CarPlate}: " + ex.ToString());
        }
    }
    Task.WaitAll(Task.WhenAll(tasks));
    Console.WriteLine("The parking lot has closed");
    Console.ReadLine();
}
catch (Exception ex)
{
    throw new Exception($"Error: {ex}");
}
