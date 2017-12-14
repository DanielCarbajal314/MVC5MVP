using BussinessLogic;
using ServicesInterface.Product;
using ServicesInterface.Product.Requests;
using ServicesInterface.Product.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Presentation.Controllers.API
{
    public class ProductController : ApiController
    {
        IProductService _productService = new ProductManager();

        public async Task<List<GeneralProduct>> Get()
        {
            return await _productService.GetAllProducts();
        }

        public async Task<GeneralProduct> Post(NewProduct productToRegister)
        {
            return await _productService.CreateProduct(productToRegister);
        }
    }
}
