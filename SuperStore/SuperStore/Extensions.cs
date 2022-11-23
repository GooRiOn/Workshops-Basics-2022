using SuperStore.Models;

namespace SuperStore;

public static class Extensions
{
    public static IEnumerable<(string categoryName, string productName)> GetCategoryProductDisplayName(this Category category) 
        => category.Products.Select(product => (category.Name, product.Name));

    public static IEnumerable<(string categoryName, string productName)> GetCategoryProductDisplayName(
        this IEnumerable<Category> categories)
        => categories.SelectMany(category => category.GetCategoryProductDisplayName());
}