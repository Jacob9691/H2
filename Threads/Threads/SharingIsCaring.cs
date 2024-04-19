
public class SharingIsCaring
{
    private int share;
    private readonly object _lock = new ();

    public SharingIsCaring()
    {
        share = 0;
    }

    public void Add()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (_lock) 
            { 
                share++;
                Thread.Sleep(500);
            }
        }
    }

    public void Read()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (_lock) 
            { 
                Console.WriteLine(share);
                Thread.Sleep(500);
            }
        }
    }
}
