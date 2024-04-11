
Dog d1 = new Dog("King", 25);
Dog d2 = new Dog("Tiny", 95);
Dog d3 = new Dog("Rufus", 36);
Dog d4 = new Dog("Spot", 55);
Dog d5 = new Dog("Daisy", 8);
List<Dog> dogs = new List<Dog> { d1, d2, d3, d4, d5 };

// Print out all Dogs with a weight larger than 40 kg.
ConditionalPrint<Dog>(dogs, dog => dog.Weight > 40);

// Print out all Dogs with a weight smaller than Rufus' weight.
ConditionalPrint<Dog>(dogs, dog => dog.Weight < d3.Weight);

// Print out all Dogs with a name that contains an "i"
ConditionalPrint<Dog>(dogs, dog => dog.Name.Contains('i'));

ConditionalPrint2<Dog>(dogs, dog => dog.Weight < d3.Weight, dog => dog.Name.Contains('i'));

List<Predicate<Dog>> predList = new List<Predicate<Dog>>
{
    dog => dog.Weight > 40,
    dog => dog.Weight < d2.Weight,
    dog => dog.Name.Contains('o')
};
MultiConditionalPrint<Dog>(dogs, predList);


static void ConditionalPrint<T>(List<T> objects, Predicate<T> pred)
{
    Console.WriteLine();
    foreach (var item in objects.FindAll(pred))
    {
        Console.WriteLine(item);
    }
}

static void ConditionalPrint2<T>(List<T> objects, Predicate<T> pred1, Predicate<T> pred2)
{
    Console.WriteLine();
    foreach (var item in objects)
    {
        if (pred1(item) && pred2(item))
            Console.WriteLine(item);
    }
}

static void MultiConditionalPrint<T>(List<T> objects, List<Predicate<T>> predList)
{
    Console.WriteLine();
    var allIsTrue = true;
    foreach (var item in objects)
    {
        allIsTrue = true;
        foreach(var pred in predList)
        {
            if (!pred(item))
            {
                allIsTrue = false;
                break;
            }
        }
        if (allIsTrue)
            Console.WriteLine(item);
    }
}


