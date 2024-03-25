using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LegoNet.Models;

[Table("set")]
public class Set
{

    [Key]
    [Column("id")]
    public string Id { get; set; } = "";

    [Column("name")]
    public string Name { get; set; } = "";

    [Column("category")]
    public string CategoryId { get; set; } = "";

    public Category Category { get; set; } = null!;

    [Column("weight")]
    public double Weight { get; set; }

    [Column("dimension_x")]
    public double DimensionX { get; set; }

    [Column("dimension_y")]
    public double DimensionY { get; set; }

    [Column("dimension_z")]
    public double DimensionZ { get; set; }

    [Column("year_released")]
    public int YearReleased { get; set; }

    [Column("rrp")]
    public double? Rrp { get; set; }

    [Column("is_discontinued")]
    public bool IsDiscontinued { get; set; }

}