using CatalogService.Business.Abstract;
using CatalogService.DataAccess.Abstract;
using CatalogService.Entities.Concrete;
using CatalogService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;

namespace CatalogService.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(CategoryDTO.CategoryAddDTO category)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryDTO.CategoryListDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}