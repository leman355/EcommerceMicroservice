using CorePackage.Helpers.Result.Abstract;
using static CatalogService.Entities.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(CategoryAddDTO category);
        IDataResult<List<CategoryListDTO>> GetAll();
    }
}