using AutoMapper;
using CatalogService.Business.Abstract;
using CatalogService.DataAccess.Abstract;
using CatalogService.Entities.Concrete;
using CatalogService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using static CatalogService.Entities.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, ISubCategoryService subCategoryService)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }

        public IResult Add(CategoryAddDTO category)
        {
            try
            {
                var mapResult = _mapper.Map<Category>(category);
                _categoryDal.Add(mapResult);
                return new SuccessResult("Elave olundu.");

            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<CategoryListDTO>> GetAll()
        {
            try
            {
                var data = _categoryDal.GetAll();
                var subCategories = _subCategoryService.GetAllSubCategories();
                var mapData = _mapper.Map<List<CategoryListDTO>>(data);

                List<CategoryListDTO> result = new();

                foreach (var category in data)
                {
                    List<string> subsList = new();
                    var res = subCategories.Data.Where(x => category.SubCategoryId.Contains(x.Id)).ToList();

                    CategoryListDTO newList = new()
                    {
                        CategoryName = category.CategoryName,
                        SubCategoryName = res.Select(x => x.SubCategoryName).ToList()
                    };
                    result.Add(newList);
                }
                return new SuccessDataResult<List<CategoryListDTO>>(result, "Data geldi");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<CategoryListDTO>>(e.Message);
            }
        }
    }
}