using CatalogService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Abstract
{
    public interface IProductService
    {
        IResult AddProduct(ProductDTO productAddDTO);
        IDataResult<List<ProductListDTO>> GetHomeProducts();
        IDataResult<List<ProductListDTO>> GetProductsById(string Id);
    }
}