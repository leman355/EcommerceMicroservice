using AutoMapper;
using CatalogService.Business.Abstract;
using CatalogService.DataAccess.Abstract;
using CatalogService.Entities.Concrete;
using CatalogService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public IResult AddProduct(ProductDTO productAddDTO)
        {
            try
            {
                var mapper = _mapper.Map<Product>(productAddDTO);
                _productDal.Add(mapper);
                return new SuccessResult("Elave olundu.");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<ProductListDTO>> GetHomeProducts()
        {
            try
            {
                var data = _productDal.GetAll();
                var result = _mapper.Map<List<ProductListDTO>>(data);
                return new SuccessDataResult<List<ProductListDTO>>(result, "Data geldi.");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<ProductListDTO>>(e.Message);
            }
        }
        public IDataResult<ProductGetByIdDTO> GetProductById(string id)
        {
            try
            {
                var data = _productDal.Get(x => x.Id == id);
                var result = _mapper.Map<ProductGetByIdDTO>(data);
                return new SuccessDataResult<ProductGetByIdDTO>(result);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ProductGetByIdDTO>(e.Message);
            }
        }
    }
}