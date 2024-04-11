
public class AnimalProcessor
{
    public void ProcessAnimals(ICollectionGet<Animal> animals)
    {
        for (int index = 0; index < animals.Count; index++)
        {
            Console.WriteLine(animals.Get(index).Sound());
            // animals.GetAnimal(index).FlapWings(); // Why does this NOT work...? there is no GetAnimals method
        }
    }

    public void ProcessBirds(ICollectionGet<Bird> birds)
    {
        for (int index = 0; index < birds.Count; index++)
        {
            Console.WriteLine(birds.Get(index).Sound());
            birds.Get(index).FlapWings(); // Why does this work..? It uses the interface to get the bird from the index
        }
    }

    public void InsertAnimals(ICollectionSet<Animal> animals)
    {
        for (int index = 0; index < 5; index++)
        {
            Bird b = new Bird("Tweety");
            b.FlapWings();
            animals.Set(b); // Why does this work..? the same with using the interface

            Cat c = new Cat("Spot");
            c.Purr();
            animals.Set(c); // Why does this work..? the same with using the interface
        }
    }

    public void InsertBirds(ICollectionSet<Bird> birds)
    {
        for (int index = 0; index < 5; index++)
        {
            Bird b = new Bird("Tweety");
            b.FlapWings();
            birds.Set(b);

            Cat c = new Cat("Spot");
            c.Purr();
            // birds.SetAnimal(c); // Why does this NOT work...? there is no SetAnimal method
        }
    }
}
