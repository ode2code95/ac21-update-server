using System;
using System.Data.Common;
using NUnit.Framework;
using Repository;
using Pure.Functions;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("199a2eb5-97be-4432-bcf3-cb7d9bb7b32f")]
        [TestCase("3871dc74-f777-48dd-a38f-048eca81d3ab")]
        public void Test(string id)
        {
            //Db.GetCustomers().ToSeq().LookupCustomer(id);
        }
    }
}
