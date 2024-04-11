
// No problem, since Collection implements 
// ICollectionGet and ICollectionSet
Collection<Bird> birds = new Collection<Bird>();
ICollectionGet<Bird> birdsGet = birds;
ICollectionSet<Bird> birdsSet = birds;

// No problem, since Collection implements 
// ICollectionGet and ICollectionSet
Collection<Animal> animals = new Collection<Animal>();
ICollectionGet<Animal> animalsGet = animals;
ICollectionSet<Animal> animalsSet = animals;


AnimalProcessor processor = new AnimalProcessor();

// How many of these work...?
//
processor.ProcessAnimals(birdsGet);   // Case A
processor.ProcessAnimals(animalsGet); // Case B

processor.ProcessBirds(birdsGet);     // Case C
//processor.ProcessBirds(animalsGet);   // Case D

//processor.InsertAnimals(birdsSet);    // Case E
processor.InsertAnimals(animalsSet);  // Case F

processor.InsertBirds(birdsSet);      // Case G
processor.InsertBirds(animalsSet);    // Case H

/*
 Task notes
    7: the out makes the interface co-variant, so now the bird class will also work as parameter for a animal method.
        Since bird inherit from the animal, but this won't work the other way around.
        So animal won't work as a parameter for a bird method.
    9: the in makes the opposite of co-variant, now making it contra-variant.
        So now animals can be used for birds method.
 */
