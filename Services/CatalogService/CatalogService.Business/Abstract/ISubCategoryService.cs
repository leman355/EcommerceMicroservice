using CorePackage.Helpers.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatalogService.Entities.DTOs.SubCategoryDTO;

namespace CatalogService.Business.Abstract
{
    public interface ISubCategoryService
    {
        IResult Add(SubCategoryAddDTO subCategory);
        IDataResult<List<SubCategoryListDTO>> GetAllSubCategories();
    }
}
