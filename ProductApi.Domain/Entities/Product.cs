using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductApi.Domain.Entities
{
    public class Product
    {
        
        public Guid Id { get; private set; }
        
        public string? Name { private get; set; }

        public decimal Price { private get; set; }

        public Product( string name, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }



        public static Product Create(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {  
                throw new ArgumentNullException("Name is required"); 
            }

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price must be greater than zero");
            }

            return new Product(name, price);
        }

    }



}
