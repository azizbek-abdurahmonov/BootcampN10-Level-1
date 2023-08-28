public class Product
{
    public Guid Id { get; init; }

    private string _name;

    public string Name
    {
        get => _name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Value is not valid");

            _name = value;
        }
    }

    private string _description;

    public string Description
    {
        get => _description;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Value is not valid");

            _description = value;
        }
    }

    public Product(string name, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    public Product(Product product)
    {
        Id = Guid.NewGuid();
        Name = product.Name;
        Description = product.Description;
    }
}