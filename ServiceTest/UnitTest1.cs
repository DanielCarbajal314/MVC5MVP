using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLogic;
using ServicesInterface.Product;
using AutoMapper;
using DataAccess.Models;
using ServicesInterface.Product.Responses;
using ServicesInterface.Product.Requests;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Mapper.Initialize(configuration => {
                configuration.CreateMap<Product, GeneralProduct>();
                configuration.CreateMap<NewProduct, Product>();
            });
        }

        [TestMethod]
        public void ProductCreation()
        {
            IProductService productService = new ProductManager();
            NewProduct newProduct = new NewProduct();
            newProduct.Name = "Candy";
            newProduct.Stock = 10;
            var registeredProduct = productService.CreateProduct(newProduct).Result;
            Assert.AreEqual(registeredProduct.Id > 0, true);
        }

        [TestMethod]
        public void ProductList()
        {
            IProductService productService = new ProductManager();
            NewProduct newProduct = new NewProduct();
            newProduct.Name = "Candy";
            newProduct.Stock = 10;
            var registeredProduct = productService.CreateProduct(newProduct).Result;
            Assert.AreEqual(registeredProduct.Id > 0, true);
            var allProducts = productService.GetAllProducts().Result;
            Assert.AreEqual(allProducts.Count >= 1, true);
        }

    }
}
