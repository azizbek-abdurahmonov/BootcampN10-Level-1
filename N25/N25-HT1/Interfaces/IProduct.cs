namespace N25_HT1.Interfaces;

public interface IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }

}