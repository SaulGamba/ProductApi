using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Application.Products.Commands;
using ProductApi.Application.Products.DTOs;
using ProductApi.Application.Products.Queries;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request)
    {
        if (request == null)
            return BadRequest("Request inválida.");

        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest("El campo 'Name' es obligatorio.");

        var id = await _mediator.Send(new CreateProductCommand(request.Name!, request.Price));
        return Ok(id);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _mediator.Send(new GetProductsQuery());
        return Ok(products);
    }
}