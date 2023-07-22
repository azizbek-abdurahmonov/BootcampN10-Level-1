// Korzinkani ishga tushurish
var product1 = new Product
{
    Id = Guid.NewGuid(),
    Name = "HP Victus"
};
var product2 = new Product
{
    Id = Guid.NewGuid(),
    Name = "Lenovo"
};
var product3 = new Product
{
    Id = Guid.NewGuid(),
    Name = "Acer"
};

//tekshirish
var shoppingcart = new ShoppingCart();
shoppingcart.Add(product1);
shoppingcart.Add(product1);
shoppingcart.Add(product1);

Console.WriteLine($"{product1.Name}, {product2.Name} va {product3.Name} qo'shildi");
Console.WriteLine($"{shoppingcart.Remove(product1)} - {product1.Name} to'g'ri o'chirildi chunki u avvaldan bor edi");

public class Product
{
    public Guid Id;
    public string Name;
}

public class ShoppingCart
{
    public Dictionary<Product, int> Items = new Dictionary<Product, int>();

    //methods
    public void Add(Product product)
    {
        if (Items.ContainsKey(product))
            Items[product]++;
        else
            Items.Add(product, 1);
    }

    public bool Remove(Product product)
    {
        if (Items.ContainsKey(product))
        {
            Items[product]--;
            return true;
        }
        else
            return false;
    }
}