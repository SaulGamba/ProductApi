using Microsoft.AspNetCore.Mvc;
using ProductApi.Application.Products;
using ProductApi.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductUseCase _createProduct;
        public ProductController(ProductUseCase createProduct)
        {
            _createProduct = createProduct;
        }

        [HttpPost]
        [Route("Execute")]
        public async Task<IActionResult> Execute([FromBody] CreateProductRequest request)
        {
            if(string.IsNullOrEmpty(request.Name))
            {
                return BadRequest("Name is required.");
            }

            await _createProduct.Create(request.Name, request.Price);
            return Ok();
        }

    }
}
