using LegoNet.Helpers;
using LegoNet.Models;
using Microsoft.EntityFrameworkCore;

namespace LegoNet.Services;

public interface ISetService
{
    Task<List<Set>> GetAllAsync();
}

public class SetService(
    DataContext context
    ) : ISetService
{

    private readonly DataContext _context = context;

    public Task<List<Set>> GetAllAsync()
    {
        return _context.Sets
            .Include(s => s.Category)
            .ToListAsync();
    }
}