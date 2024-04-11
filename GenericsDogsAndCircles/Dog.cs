
public class Dog : IComparable<Dog>
{
    #region Properties
    public string Name { get; }
    public int Height { get; }
    public double Weight { get; }
    #endregion

    #region Constructor
    public Dog(string name, int height, double weight)
    {
        Name = name;
        Height = height;
        Weight = weight;
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"{Name} is {Height} cm tall, and weighs {Weight} kgs.";
    }

    public int CompareTo(Dog? Dog)
    {
        if (Dog == null) return 1;

        Dog otherDog = Dog;
        return Weight.CompareTo(otherDog.Weight);
    }
    #endregion
}
