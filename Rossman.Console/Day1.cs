// Func<int, int, int> add = (a, b) => a + b;
//
// Expression<Func<int, int, int>> addExpression = (a, b) => a + b;
//
// addExpression.Compile()(1, 2);
//
// Console.WriteLine();
//
// Func<int, string> convert = x => x.ToString();
//
// Func<int> getRandomNumber = () => new Random().Next();
//
// Func<int, Func<int>> getPoweredFunc = x => () => x * x;
// Action<int, int> printSum = (x, y) => Console.WriteLine($"{x} + {y}");
//
// var powFunc = getPoweredFunc(3);
//
// var pow = powFunc();
//
//
// Func<User, bool> predicate = x => x.Age > 30;
//
//
//
// var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
//
// //var evenNumbers = new List<int>();
//
//
// var users = new List<User>
// {
//     new() {FullName = "Joe Doe", Age = 18},
//     new() {FullName = "Mark Doe", Age = 30},
//     new() {FullName = "Tim Doe", Age = 45},
//     new() {FullName = "Samanta Doe", Age = 15},
//     new() {FullName = "Ivy Doe", Age = 99},
//     new() {FullName = "Test Doe", Age = 76},
// };
//
//
// var result = users
//     .Where(user => user.Age is >= 18 and < 50)
//     .Select(user => new
//     {
//         MyCustomAge = user.Age + 1, 
//         MyCustomFullName = $"{user.FullName} ###",
//     })
//     .OrderByDescending(x => x.MyCustomAge);
//
//
// var ageAvg = users
//     .Where(user => user.Age > 20)
//     .Average(user => user.Age);
//
// Console.WriteLine(ageAvg);
//
// var mapper = new ExceptionToMessageMapper();
// var message = mapper.Map(new DivideByZeroException());
//
// //_ = user ?? throw new ArgumentException();
//
//
// var user = new User
// {
//     FullName = "Joe Doe"
// };
//
// user = null;
//
// Console.WriteLine(user?.FullName);
//
// new MyService().PrintUserFullName(null);
//
//
// class ExceptionToMessageMapper
// {
//     public string Map(object exception)
//         => exception switch
//         {
//             InvalidUserAgeException ex => "Invalid user age!",
//             InvalidUserFullNameException ex => "Invalid user name",
//             _ => "There was an error"
//         };
// }
//
//
// public class BaseException : Exception
// {
//     
// }
//
// public class InvalidUserFullNameException : BaseException
// {
//     
// }
//
//
// public class InvalidUserAgeException : BaseException
// {
//     
// }
//
// public class MyService
// {
//     public void PrintUserFullName(User user)
//     {
//
//         Console.WriteLine(user?.FullName ?? "Default value");
//     }
// }