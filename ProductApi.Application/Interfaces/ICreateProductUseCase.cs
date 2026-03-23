using ProductApi.Application.Products;

namespace ProductApi.Application.Interfaces
{
    public interface ICreateProductUseCase
    {
       public Task<CreateProductRequest> Create(string name, decimal price);
    }
}