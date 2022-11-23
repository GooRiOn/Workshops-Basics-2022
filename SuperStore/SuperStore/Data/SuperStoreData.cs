using SuperStore.Models;

namespace SuperStore.Data;

public class SuperStoreData
{
    private static Random _random = new();

    public IEnumerable<Category> GetData()
    {
        var categories = Enumerable.Range(1, 10).Select(x => new Category
        {
            Name = $"Category #{x}"
        }).ToList();

        foreach (var category in categories)
        {
            var products = Enumerable.Range(1, 5).Select(y => new Product
            {
                Name = $"Product #{y}",
                Price = _random.Next(1, 100),
                Dessciption = "fgrdthgyjhjlk;kjhgfc"
            });

            foreach (var product in products)
            {
                category.AddProduct(product);
            }
        }

        return categories;
    }
}