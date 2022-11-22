// C# 1 Begin/Invoke

// C# 2 Event-Based

// C# Task-Based

// async/await 

using System.Runtime.CompilerServices;
using System.Text;
using External.Assembly;
var service = new UsersService();

//var task2 = new Task2();

//await task2;

var user1 =  service.GetByIdAsync(Guid.NewGuid());
var user2 =  await service.GetByIdAsync(Guid.NewGuid());

Console.ReadLine();
var ids = new[] {Guid.NewGuid(), Guid.NewGuid(),};
//var users = new List<User>();

//var tasks = ids
  //  .Select(id => service.GetByIdAsync(id));

//var users = await Task.WhenAll(tasks);

Console.WriteLine();

//First - FirstOrDefault
//Single - SingleOrDefault

public class UsersService
{
    private readonly DatabaseConnector _connector = new();

    public Task<User> GetByIdAsync(Guid id)
        => _connector.GetByIdAsync(id, 10_000);
}

public class DatabaseConnector
{
    public User GetById(Guid id)
    {
        Console.WriteLine("Connecting to db...");
        Thread.Sleep(10_000);
        Console.WriteLine("Connected to db!");

        return new User {Id = id, FullName = "Joe Doe", Age = 18};
    }

    public async Task<User> GetByIdAsync(Guid id, int delay)
    {
        Console.WriteLine("Connecting to db...");
        await Task.Delay(delay); // throw new NotImplementedException();
        Console.WriteLine("Connected to db!");

        return new User {Id = id, FullName = "Joe Doe", Age = 18};
    }

    public async void Test() // fire and forget
    {
        Console.WriteLine("Test");
    }

    //C# 4 
    public void Test2()
    {
        var await = 2;
    }
}

//

public class Task2
{
    public TaskAwaiter2 GetAwaiter()
    {
        return new TaskAwaiter2();
    }
        
}

public class TaskAwaiter2 : INotifyCompletion
{
    public bool IsCompleted { get; set; } = true;
    public void OnCompleted(Action continuation)
    {
    }

    public void GetResult()
    {
        Console.WriteLine("WOW!");
    }
}