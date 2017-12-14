using ServicesInterface.Product.Requests;
using ServicesInterface.Product.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterface.Product
{
    public interface IProductService
    {
        Task<GeneralProduct> CreateProduct(NewProduct newProduct);
        Task<List<GeneralProduct>> GetAllProducts();
    }
}
