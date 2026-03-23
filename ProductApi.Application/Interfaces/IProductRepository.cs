using ProductApi.Application.Products;
using ProductApi.Domain.Entities;

namespace ProductApi.Application.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<List<Product>> GetAllAsync();
    }
}