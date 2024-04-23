public class ScopedLocker : IDisposable
{
    private readonly Mutex _mutex;

    public ScopedLocker(Mutex mutex)
    {
        _mutex = mutex;
        _mutex.WaitOne();
    }

    public void Dispose()
    {
        _mutex.ReleaseMutex();
    }
}