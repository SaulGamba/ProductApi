using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductApi.Application.Products.DTOs
{
    public class CreateProductRequest
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }
    }
}
