using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Application.Products.DTOs
{
public class ProductResponse
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}
}
