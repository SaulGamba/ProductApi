using ProductApi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Application.Products
{
    public class ProductUseCase: ICreateProductUseCase
    {

        public Task<CreateProductRequest> Create(string name, decimal price)
        {
            var request = new CreateProductRequest
            {
                Name = name,
                Price = price
            };
            return Task.FromResult(request);
        }

    }
}
