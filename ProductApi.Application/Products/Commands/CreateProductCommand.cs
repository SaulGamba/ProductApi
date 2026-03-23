using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ProductApi.Application.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price) : IRequest<Guid>;
}
