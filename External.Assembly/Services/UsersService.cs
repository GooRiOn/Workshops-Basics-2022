// namespace External.Assembly.Services;
//
// public class UsersService
// {
//     private static int _number = 1;
//     public User Create(string fullName)
//     {
//         var user = new User
//         {
//             Id = Guid.NewGuid(),
//             FullName = $"#{_number} {fullName}"
//         };
//
//         _number++;
//         
//         return user;
//     }
// }
//
// public class MyClass
// {
//     public Func<int> GetValue()
//     {
//         var value = 1;
//
//         return () => value;
//     }
// }