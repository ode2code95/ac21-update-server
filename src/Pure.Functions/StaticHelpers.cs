using System;
using System.Collections.Generic;
using System.Linq;
using Pure.Functions.Models;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Pure.Functions
{
    public static class StaticHelpers
    {
        /// <summary>
        /// Please no! This won't tell you if it fails!
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer LookupCustomer(this IEnumerable<Customer> customers, Guid id) =>
            customers.FirstOrDefault(c => c.Id == id);

        public static Option<Customer> SafeLookupCustomer1(this IEnumerable<Customer> customers, Guid id) =>
            customers.FirstOrDefault(c => c.Id == id).Apply(Optional);

        public static Option<Customer> SafeLookupCustomer2(this IEnumerable<Customer> customers, Guid id) =>
            customers.Filter(c => c.Id == id).HeadOrNone();

        public static Validation<string, Customer> SafeLookupCustomer3(this IEnumerable<Customer> customers, Guid id)
        {
            var c = customers.FirstOrDefault(c => c.Id == id);
            return c != null ? Success<string, Customer>(c) : Fail<string, Customer>("Record not found!");
        }

        public static void TryIt()
        {
            var custList = new Guid[]{};
            custList.SafeLookupCustomer3(Guid.NewGuid())
                .Match();
        }
    }
}
