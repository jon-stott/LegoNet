using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegoNet.Models;

[Table("category")]
public class Category : IComparable<Category>
{

    [Column("id", TypeName = "varchar(50)")]
    public string Id { get; set; } = "";

    [Column("name", TypeName = "varchar(1023)")]
    public string Name { get; set; } = "";

    public int CompareTo(Category? other)
    {
        return other == null ? 1 : Name.CompareTo(other.Name);
    }

}