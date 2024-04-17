
#pragma warning disable 4014

// Sets up and starts a scenario
// Scenario<Data> theScenario = new Scenario<Data>(40, 20, 40, 100, 80, Reporter<Data>.ReportMode.verbose);
Scenario<Data> theScenario = new Scenario<Data>(1000, 500, 1000, 2, 2, Reporter<Data>.ReportMode.verbose);
await theScenario.RunAsync();

Console.WriteLine("Press any key to abort the run...");
Console.ReadKey();

/*
 Task notes:
    3: The reason why they are both printing at the same time, is because there is no locking.
        There need to be a lock, so the two task can't access the printing code at the same time.
        To do this, there need to be a private object in the reporter class, then use lock(object){...}.
        So now a thread will wait at the lock, when another thread is accessing the code.
    4: The reason why "Press any key to abort the run..." is printed. Is because the part that prints it,
        doesn't wait for the scenario to finish. We don't see it in verbose mode, because it's get cleared away,
        when the tasks start printing. But that line should be the last one to be printed. 
        Therefore an await is needed.
    6: The data that can be accessed by both the producer and consumer, is the queue. But the reason for why
        there is balances problems, is that there are being consumed more than there is produce. 
        And that is haft to do with the delay. So the delay have to be depended on how much is being pruduce
        and consumed.
    7: By add one more task for the producer, then production will be a lot faster. The same can be said for consumer,
        if there was added a task more for them.
 */
