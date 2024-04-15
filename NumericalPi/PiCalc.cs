
public class PiCalc
{
    /// <summary>
    /// Executes the calculation of an 
    /// approximate value of pi.
    /// </summary>
    /// <param name="iterations">Number of iterations to perform</param>
    /// <returns>Approximate value of pi</returns>
    public double Calculate(int iterations)
    {
        //int insideUnitCircle = Iterate(iterations);
        //return insideUnitCircle * 4.0 / iterations;

        Task<int> insideUnitCircle1 = Task<int>.Run(() => Iterate(iterations / 4));
        Task<int> insideUnitCircle2 = Task<int>.Run(() => Iterate(iterations / 4));
        Task<int> insideUnitCircle3 = Task<int>.Run(() => Iterate(iterations / 4));
        Task<int> insideUnitCircle4 = Task<int>.Run(() => Iterate(iterations / 4));

        Task<int>.WaitAll(insideUnitCircle1, insideUnitCircle2, insideUnitCircle3, insideUnitCircle4);
        return((
            insideUnitCircle1.Result + 
            insideUnitCircle2.Result +  
            insideUnitCircle3.Result + 
            insideUnitCircle4.Result) * 4.0 / iterations
            );
    }

    /// <summary>
    /// Perform a number of "dart-throwing" simulations.
    /// </summary>
    /// <param name="iterations">Number of dart-throws to perform</param>
    /// <returns>Number of throws within the unit circle</returns>
    public int Iterate(int iterations)
    {
        Random _generator = new Random(Guid.NewGuid().GetHashCode());
        int insideUnitCircle = 0;

        for (int i = 0; i < iterations; i++)
        {
            double x = _generator.NextDouble();
            double y = _generator.NextDouble();

            if (x * x + y * y < 1.0)
            {
                insideUnitCircle++;
            }
        }

        return insideUnitCircle;
    }
}
