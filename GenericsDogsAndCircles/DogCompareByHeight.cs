public class DogCompareByHeight : IComparer<Dog>
{
    public int Compare(Dog? x, Dog? y)
    {
        if (x == null || y == null) throw new ArgumentNullException();

        return x.Height == y.Height 
            ? 0 
            : x.Height > y.Height 
                ? 1 
                : -1;
    }
}

