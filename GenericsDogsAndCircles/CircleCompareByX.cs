
public class CircleCompareByX : IComparer<Circle>
{
    public int Compare(Circle? a, Circle? b)
    {
        if (a == null || b == null) throw new ArgumentNullException();

        return a.X == b.X
            ? 0
            : a.X > b.X
                ? 1
                : -1;
    }
}

