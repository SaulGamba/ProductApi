using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Application.Products.Queries
{
    public record GetProductsQuery() : IRequest<List<ProductResponse>>;
}
