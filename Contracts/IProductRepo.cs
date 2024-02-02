using Cubic.API.Models;

namespace Cubic.API.Contracts;

public interface IProductRepo
{
    Task<List<Product>> GetAll();
    Task<Product?> GetById(int id);
}
