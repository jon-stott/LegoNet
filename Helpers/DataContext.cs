namespace LegoNet.Helpers;

using LegoNet.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;


    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("LegoDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Colour>()
            .HasKey(c => c.BricklinkId)
            .HasName("colour_pkey");
        modelBuilder
            .Entity<Colour>()
            .Property(e => e.TypeOfColour)
            .HasConversion<string>();
        modelBuilder
            .Entity<Category>()
            .HasKey(c => c.Id)
            .HasName("category_pkey");
        modelBuilder
            .Entity<Set>()
            .HasKey(s => s.Id)
            .HasName("set_pkey");
        modelBuilder
            .Entity<Set>()
            .HasOne(e => e.Category)
            .WithOne()
            .HasForeignKey<Set>(e => e.CategoryId);
            // .HasConstraintName("set_category_fkey")
            // .IsRequired();
    }

    public DbSet<Colour> Colours { get; set; }

    public DbSet<Set> Sets { get; set; }

}
