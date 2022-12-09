using AutoMapper;
using CatalogService.Business.Abstract;
using CatalogService.DataAccess.Abstract;
using CatalogService.DataAccess.Concrete.MongoDb;
using CatalogService.Entities.Concrete;
using CatalogService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatalogService.Entities.DTOs.SubCategoryDTO;

namespace CatalogService.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;
        private readonly IMapper _mapper;

        public SubCategoryManager(ISubCategoryDal subCategoryDal, IMapper mapper)
        {
            _subCategoryDal = subCategoryDal;
            _mapper = mapper;
        }

        public IResult Add(SubCategoryAddDTO subCategory)
        {
            try
            {
                var mapper = _mapper.Map<SubCategory>(subCategory);
                _subCategoryDal.Add(mapper);
                return new SuccessResult("Elave olundu.");
            }
            catch (Exception)
            {
                return new ErrorResult("Error oldu.");
            }
        }

        public IDataResult<List<SubCategoryListDTO>> GetAllSubCategories()
        {
            try
            {
                var data = _subCategoryDal.GetAll();
                var result = _mapper.Map<List<SubCategoryListDTO>>(data);

                return new SuccessDataResult<List<SubCategoryListDTO>>(result);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<SubCategoryListDTO>>("Error oldu.");
            }
        }
    }
}
