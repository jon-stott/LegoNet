using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegoNet.Models;

[Table("colour")]
public class Colour : IComparable<Colour>
{

    [Column("bricklink_id")]
    public long BricklinkId { get; set; }
    
    [Column("bricklink_name")]
    public string BricklinkName { get; set; } = "";

    [Column("lego_id")]
    public int LegoId { get; set; }

    [Column("lego_name")]
    public string LegoName { get; set; } = "";

    // alter table public.colour
    // add colour_type varchar(63) default ''::character varying not null;
    [Column("colour_type")]
    public ColourType TypeOfColour { get; set; }

    [Column("rgb")]
    public string? Rgb { get; set; }

    public int CompareTo(Colour? other)
    {
        return other == null ? 1 : BricklinkName.CompareTo(other.BricklinkName);
    }
}

public enum ColourType
{
    Solid,
    Pearl,
    Transparent,
    Milky,
    Speckle,
    Glitter,
    Metallic,
    Chrome,
    Opal,
}