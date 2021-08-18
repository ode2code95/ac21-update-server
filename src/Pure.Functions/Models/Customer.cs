using System;

namespace Pure.Functions.Models
{
    public class Customer
    {
        public string Name { get; }

        public Guid Id { get; }

        public ClientProduct[] Products { get; }

        public Customer(string name, Guid id, ClientProduct[] products)
        {
            Name = name;
            Id = id;
            Products = products;
        }
    }
}
