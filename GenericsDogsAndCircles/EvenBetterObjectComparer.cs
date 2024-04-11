
public class EvenBetterObjectComparer
{
    public T Largest<T>(T a, T b, T c, IComparer<T> comparer)
    {
        if (a == null || b == null || c == null || comparer == null) 
            throw new ArgumentNullException();
        
        if (comparer.Compare(a, b) == 1)
            return comparer.Compare(a, c) == 1 ? a : c;

        return comparer.Compare(b, c) == 1 ? b : c;
    }
}
