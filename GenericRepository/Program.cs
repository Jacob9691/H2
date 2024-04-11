Repository<Car> cars = new Repository<Car>();

Car c1 = new Car("AB 12 345", 80000);
Car c2 = new Car("CD 34 456", 65000);
Car c3 = new Car("EF 56 567", 28000);

cars.Insert(c1.LicensePlate, c1);
cars.Insert(c2.LicensePlate, c2);
cars.Insert(c3.LicensePlate, c3);

cars.PrintAll();


Repository<Employee> employees = new();

Employee e1 = new Employee("Allan", 1962);
Employee e2 = new Employee("Bente", 1975);
Employee e3 = new Employee("Carlo", 1973);

employees.Insert(e1.Name, e1);
employees.Insert(e2.Name, e2);
employees.Insert(e3.Name, e3);

employees.PrintAll();


Repository<Computer> computers = new();

Computer pc1 = new Computer("1234", "Network1");
Computer pc2 = new Computer("4321", "Network2");
Computer pc3 = new Computer("2143", "Network3");

computers.Insert(pc1.SerialNo, pc1);
computers.Insert(pc2.SerialNo, pc2);
computers.Insert(pc3.SerialNo, pc3);

computers.PrintAll();


Repository<Phone> phones = new();

Phone p1 = new Phone("IPhone 15", "Apple");
Phone p2 = new Phone("Samsung Galaxy S24", "Samsung");
Phone p3 = new Phone("Huawei P50 Pro", "Huawei");

phones.Insert(p1.Model, p1);
phones.Insert(p2.Model, p2);
phones.Insert(p3.Model, p3);

phones.PrintAll();

/*
 Task notes
    1: They both use an Insert method, to add to their lists, and they also have a delete method. 
        Where it deletes an item, with using it's name as a key. They can also both call a all list,
        to see every item in their list.
 */
