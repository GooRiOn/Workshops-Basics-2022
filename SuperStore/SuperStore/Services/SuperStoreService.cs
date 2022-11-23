using SuperStore.Data;
using SuperStore.Models;

namespace SuperStore.Services;

public sealed class SuperStoreService
{
    private readonly IEnumerable<Category> _categories;

    public SuperStoreService()
    {
        var data = new SuperStoreData();
        _categories = data.GetData();
    }

    public void AddProduct(Product product, string categoryName)
    {
        var selectedCategory = GetCategoryByName(categoryName);
        selectedCategory.AddProduct(product);
    }

    public Product FindCheapestProduct()
        => _categories?.SelectMany(x => x.Products)?.MinBy(x => x.Price);

    public Product FindMostExpensiveProductFromCategory(string categoryName)
    {
        var selectedCategory = GetCategoryByName(categoryName);
        return selectedCategory.Products.MaxBy(x => x.Price);
    }
    
    public IEnumerable<Product> GetAllProductsWithPriceBelowAverage(string categoryName)
    {
        var selectedCategory = GetCategoryByName(categoryName);
        return selectedCategory.Products.Where(x => x.Price < selectedCategory.Products.Average(p => p.Price));
    }

    public IEnumerable<(string categoryName, string productName)> GetProductCategoryDetails()
        => _categories.GetCategoryProductDisplayName();

    private Category GetCategoryByName(string categoryName)
    {
        var category = _categories.SingleOrDefault(x => x.Name == categoryName);

        if (category is null)
        {
            throw new ArgumentException($"Cannot find category with name {categoryName}");
        }

        return category;
    }
}