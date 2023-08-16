using N25_HT1.Interfaces;

namespace N25_HT1.Models;

public class ProductFilterDataModel
{
    public List<string> ProductTypes { get; }

    public ProductFilterDataModel(List<IProduct> products)
    {
        if (products.Count == 0)
            ProductTypes = new();
        else
            ProductTypes = products.Select(item => item.GetType().FullName).Distinct().ToList();
    }
}