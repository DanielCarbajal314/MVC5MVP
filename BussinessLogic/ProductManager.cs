using ServicesInterface.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesInterface.Product.Requests;
using ServicesInterface.Product.Responses;
using DataAccess;
using DataAccess.Models;
using AutoMapper;
using System.Data.Entity;

namespace BussinessLogic
{
    public class ProductManager : IProductService
    {
        public async Task<GeneralProduct> CreateProduct(NewProduct newProduct)
        {
            using (StoreContext storeDb = new StoreContext())
            {
                Product product = Mapper.Map<Product>(newProduct);
                storeDb.Products.Add(product);
                await storeDb.SaveChangesAsync();
                return Mapper.Map<GeneralProduct>(product);
            }
        }

        public async Task<List<GeneralProduct>> GetAllProducts()
        {
            using (StoreContext storeDb = new StoreContext())
            {
                var products = await storeDb.Products.ToListAsync();
                return products.Select(x => Mapper.Map<GeneralProduct>(x)).ToList();
            }
        }
    }
}
