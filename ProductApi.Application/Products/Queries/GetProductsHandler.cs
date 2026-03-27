using MediatR;
using ProductApi.Application.Interfaces;
using ProductApi.Application.Products.DTOs;
using ProductApi.Application.Products.Queries;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<ProductResponse>>
{
    private readonly IProductRepository _repository;

    public GetProductsHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllAsync();

        return products.Select(p => new ProductResponse
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price
        }).ToList();
    }
}