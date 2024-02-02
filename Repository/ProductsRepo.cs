using Cubic.API.Context;
using Cubic.API.Contracts;
using Cubic.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cubic.API.Repository;

public class ProductsRepo : IProductRepo
{
    private readonly ApplicationContext _context;
    public ProductsRepo(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAll()
    {
       return await _context.Set<Product>().ToListAsync();
    }

    public async Task<Product?> GetById(int id)
    {
        return await _context.Set<Product>().FindAsync(id);
    }
}
