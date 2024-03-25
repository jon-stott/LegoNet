using LegoNet.Helpers;
using LegoNet.Models;
using Microsoft.EntityFrameworkCore;

namespace LegoNet.Services;

public interface IColourService
{
    Task<List<Colour>> GetAllAsync();
}

public class ColourService(
    DataContext context
    ) : IColourService
{

    private readonly DataContext _context = context;

    public Task<List<Colour>> GetAllAsync()
    {
        return _context.Colours.ToListAsync();
    }
}