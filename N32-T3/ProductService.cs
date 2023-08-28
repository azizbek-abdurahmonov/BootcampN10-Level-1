public class ProductService
{
    private static ProductService _instance;
    private List<Product> _products = new();

    public static ProductService GetInstance()
    {
        if (_instance == null)
            _instance = new ProductService();

        return _instance;
    }

    private ProductService()
    {
    }

    public Product Add(string name, string description)
    {
        var product = new Product(name, description);
        _products.Add(product);
        return product;
    }

    public void Clone(Guid id)
    {
        var product = _products.FirstOrDefault(x => x.Id == id);
        if (product != null)
        {
            var copy = new Product(product);
            _products.Add(copy);
        }
    }

    public void Display()
    {
        _products.ForEach(Console.WriteLine);
    }
}