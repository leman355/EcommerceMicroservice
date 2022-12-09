using CatalogService.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using static CatalogService.Entities.DTOs.SubCategoryDTO;

namespace CatalogService.Api.Controllers
{
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var subcategories = _subCategoryService.GetAllSubCategories();
            if (!subcategories.Success)
            {
                return Ok(subcategories.Message);
            }
            return Ok(subcategories);
        }

        [HttpGet("add")]
        public IActionResult Add(SubCategoryAddDTO subCategory)
        {
            var newSubcategory = _subCategoryService.Add(subCategory);
            if (!newSubcategory.Success)
            {
                return Ok(newSubcategory.Message);
            }
            return Ok(newSubcategory.Message);
        }
    }
}
