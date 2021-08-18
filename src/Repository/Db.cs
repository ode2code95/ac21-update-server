using System;
using System.Collections.Generic;
using System.Linq;
using Pure.Functions.Models;

namespace Repository
{
    public static class Db
    {
        private static Dictionary<Guid, Customer> _customers;
        private static Dictionary<Guid, VendorProduct> _vendorProducts;

        public static Dictionary<Guid, Customer> GetCustomers() =>
            _customers ??= Factory.MakeCustomers();

        public static Dictionary<Guid, VendorProduct> GetVendorProducts() =>
            _vendorProducts ??= Factory.MakeVendorProducts();
    }

    internal static class Factory
    {
        public static Dictionary<Guid, Customer> MakeCustomers() =>
            new List<Customer>() {
                new Customer("M. D. Wholesale", Guid.Parse("199a2eb5-97be-4432-bcf3-cb7d9bb7b32f"), new ClientProduct[] {
                    new ClientProduct(Guid.Parse("abb64b36-b0f3-43e6-87fd-a0f8fe7e5409"), Version.Parse("1.7"), Version.Parse("3.2")),
                    new ClientProduct(Guid.Parse("e4587441-6d44-437a-b33e-a7ea15f8a3ce"), Version.Parse("1.7"), Version.Parse("3.2"))
                }),
                new Customer("J. D. Martin Supply", Guid.Parse("df9a951c-5d17-405b-abfd-56ccaeeccf51"), new ClientProduct[] {
                    new ClientProduct(Guid.Parse("69668938-a906-45d0-b109-dfcccfaf2c47"), Version.Parse("1.7"), Version.Parse("3.2"))
                })
            }.ToDictionary(c => c.Id);

        public static Dictionary<Guid, VendorProduct> MakeVendorProducts() =>
            new List<VendorProduct>() {
                new VendorProduct(Guid.Parse("abb64b36-b0f3-43e6-87fd-a0f8fe7e5409"), "", Version.Parse("4.2")),
                new VendorProduct(Guid.Parse("69668938-a906-45d0-b109-dfcccfaf2c47"), "", Version.Parse("3.9"))
            }.ToDictionary(vp => vp.Id);
    }
}
