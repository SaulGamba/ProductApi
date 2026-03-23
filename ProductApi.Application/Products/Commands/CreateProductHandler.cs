using MediatR;
using ProductApi.Application.Interfaces;
using ProductApi.Application.Products.Commands;
using ProductApi.Domain.Entities;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductHandler(IProductRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Price);

        await _repository.AddAsync(product);
        await _unitOfWork.SaveChangesAsync();

        return product.Id;
    }
}