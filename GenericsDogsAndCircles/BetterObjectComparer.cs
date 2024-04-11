
public class BetterObjectComparer<T> where T : IComparable<T>
{
    public T Largest(T a, T b, T c)
    {
        if (a.CompareTo(b) == 1)
        {
            return a.CompareTo(c) == 1 ? a : c; 
        }
        return b.CompareTo(c) == 1 ? b : c;
    }
}

