namespace SuperStore.Models;

public class Category
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public IEnumerable<Product> Products => _products;

    private HashSet<Product> _products = new();

    public void AddProduct(Product product)
        => _products.Add(product);
    
}