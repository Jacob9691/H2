
Movie movieA = new Movie("Alien", "Ridley Scott", 112);
Movie movieB = new Movie("Inception", "Christopher Nolan", 162);
Movie movieC = new Movie("The Shining", "Stanley Kubrick", 146);

Console.WriteLine("Before calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, taking {movieA.Runtime} minutes, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, taking {movieB.Runtime} minutes, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine($"{movieC.Title}, by {movieC.Director}, taking {movieC.Runtime} minutes, " +
                  $"watched it {movieC.NoOfViews} time(s)");
Console.WriteLine();

movieA.Watch();
movieA.Watch();
movieB.Watch();
movieC.Watch();

Console.WriteLine("After calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, taking {movieA.Runtime} minutes, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, taking {movieB.Runtime} minutes, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine($"{movieC.Title}, by {movieC.Director}, taking {movieC.Runtime} minutes, " +
                  $"watched it {movieC.NoOfViews} time(s)");
Console.WriteLine();
