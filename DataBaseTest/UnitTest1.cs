using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System.Linq;

namespace DataBaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (StoreContext storeDb = new StoreContext())
            {
                storeDb.Products.ToList();
            }
        }
    }
}
