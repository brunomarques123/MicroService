using GeekShopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModels>> FindAllProducts();
        Task<ProductModels> FindProductById(long id);
        Task<ProductModels> CreateProduct(ProductModels model);
        Task<ProductModels> UpdateProduct(ProductModels model);
        Task<bool> DeleteProductById(long id);
    }
}
