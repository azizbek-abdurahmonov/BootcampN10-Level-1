var contacts = new[]
{
    "Peter Michael Brown",
    "John David Smith",
    "John Johns Jones",
    "G`ishtmat G`ishtmatov G`ishtmatovich"
};


Console.WriteLine("KEyword kiriting: ");
var keyword = Console.ReadLine();

foreach (var contact in contacts)
{
    if(contact.Contains(keyword, StringComparison.OrdinalIgnoreCase))
        Console.WriteLine(contact);
}