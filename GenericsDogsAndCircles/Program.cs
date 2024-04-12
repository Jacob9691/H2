
#region Dog objects
Dog dog1 = new Dog("King", 70, 55);
Dog dog2 = new Dog("Spot", 30, 10);
Dog dog3 = new Dog("Rufus", 80, 40);
#endregion

#region Circle objects
Circle c1 = new Circle(10, 2, 3);
Circle c2 = new Circle(15, 6, 0);
Circle c3 = new Circle(8, 12, 7);
#endregion

#region ObjectComparer test
//ObjectComparer comparer = new ObjectComparer();
//Console.WriteLine(comparer.LargestDog(dog1, dog2, dog3));
//Console.WriteLine(comparer.LargestCircle(c1, c2, c3));

//BetterObjectComparer<Dog> dogComparer = new();
//BetterObjectComparer<Circle> circleComparer = new();
//Console.WriteLine(dogComparer.Largest(dog1, dog2, dog3));
//Console.WriteLine(circleComparer.Largest(c1, c2, c3));

Console.WriteLine();
EvenBetterObjectComparer betterComparer = new();

var circleByX = new CircleCompareByX();
Console.WriteLine(betterComparer.Largest<Circle>(c1, c2, c3, circleByX));

var dogByHeight = new DogCompareByHeight();
Console.WriteLine(betterComparer.Largest<Dog>(dog1, dog2, dog3, dogByHeight));
#endregion


/*
 Exercise OOP 2.10 Task notes
    1: The problem with class ObjectComparer, is that it has two methods for dogs and circles. 
        But it reuse the same code for them both. This could be made better with generic code,
        where there is one method that can take both classes.
    7: In terms of coupling in the code. Then before, the ObjectComparer was depended on there being a dog and circle class, 
        and that they have a weight and area parameter. 
        Now the comparer only need the two classes to have implemented the CompareTo method.

 Exercise OOP 2.11 Task notes
    6: In this solution, instead of betterObjectComparer, now the task of comparing is removed from the dog and circle class
        (So they don't need the IComparer interface anymore).
        Now the two comparing is happening in their own classes. And since the even better comparer uses generic type parameters,
        there can be added more classes with comparer classes, without needing to change the code.
 */
