using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductApi.Application.Products
{
    public class CreateProductRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        public string? Name {  get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price {  get; set; }
    }
}
