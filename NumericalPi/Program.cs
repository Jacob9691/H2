
using System.Diagnostics;

Stopwatch watch = new Stopwatch();
PiCalc calculator = new PiCalc();

Console.WriteLine("Started");
watch.Start();
double numPi = calculator.Calculate(100000000);
watch.Stop();
Console.WriteLine("Done");

Console.WriteLine($"Numeric PI = {numPi:0.000000}");
Console.WriteLine($"Real PI    = {Math.PI:0.000000}");
Console.WriteLine($"Took {watch.ElapsedMilliseconds} milliSecs");
Console.WriteLine();

/*
 Task notes:
    1: To utilise my 3 new friends, I will give them each a task to do the throws. But I'll divide the trows among us.
        So now it will speed up, since only one task need to do 25.000.000 throws now, instead of 100.000.000.
    3: The old version took 3040 milliSecs, while my new version took 1147 milliSecs. So dividing the code to 4 tasks,
        helps a lot with the speed.
    4: I have an Intel Core i7 8th gen, so it has 6 cores. And because of this, 
        my CPU has no problem calculating 4 tasks. That is why the perfomance got improved a lot,
        by dividing it into tasks.
 */
