
using External.Assembly;

var  users = new List<User>
{
    new () {Age = 82},
    new () {Age = 52},
    new () {Age = 72},
};


    

var reservations = users.SelectMany(user => user.Reservations);


var result = users.MyAwesomeSelect(x => x.Age);
Console.ReadLine();


static class Extensions
{
    public static IEnumerable<TResult> MyAwesomeSelect<TSource,TResult>(this IEnumerable<TSource> source,
        Func<TSource, TResult> map)
    {
        foreach (var element in source)
        {
            var mappedElement = map(element);
            yield return mappedElement;
        }
    }
}
