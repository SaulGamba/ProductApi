using Microsoft.AspNetCore.Mvc;
using ProductApi.Application.UseCases;
using ProductApi.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly CreateProductUseCase _createProduct;
        public ProductController(CreateProductUseCase createProduct)
        {
            _createProduct = createProduct;
        }

        [HttpPost]
       
        public IActionResult Execute(Product products)
        {
            if (products?.Name is not string name)
                return BadRequest("Name is required.");

            _createProduct.Execute(products.Name, products.Price);
            return Ok();
        }

    }
}
