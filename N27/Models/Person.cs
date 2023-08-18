using System.ComponentModel.DataAnnotations.Schema;

namespace N27.Models;

[Table("person")]
public class PersonDB
{
    [Column("id")]
    public int Id { get; set; }
    [Column("login")]
    public string? Login { get; set; }
    [Column("email")]
    public string? Email { get; set; }
    [Column("age")]
    public int Age { get; set; }
}