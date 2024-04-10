public class Repository<T> where T : class
{
    private Dictionary<string, T> _repository;

    public Repository()
    {
        _repository = new Dictionary<string, T>();
    }

    public List<T> All
    {
        get { return _repository.Values.ToList(); }
    }

    public int Count 
    {
        get { return _repository.Count; }
    }

    public void Insert(string key, T item)
    {
        if (!_repository.ContainsKey(key))
        {
            _repository.Add(key, item);
        }
    }

    public void Delete(string key)
    {
        _repository.Remove(key);
    }

    public void PrintAll()
    {
        Console.WriteLine($"Item count: {Count}");
        foreach (var item in _repository.Values)
        {
            Console.WriteLine(item);
        }
    }
}

