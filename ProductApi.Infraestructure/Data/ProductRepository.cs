using Microsoft.EntityFrameworkCore;
using ProductApi.Application.Interfaces;
using ProductApi.Domain;
using ProductApi.Domain.Entities;
using ProductApi.Infrastructure.Data;

namespace ProductApi.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}