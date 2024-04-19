
public class HalloFromThread
{
    private readonly int _id;
    public HalloFromThread(int id)
    {
        _id = id;
    }

    public void ThreadHallos()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hallo #{i} from thread {_id}");
        }

        Console.WriteLine($"Thread {_id} terminates");
    }

}
