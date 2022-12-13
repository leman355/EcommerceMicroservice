using CatalogService.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using static CatalogService.Entities.DTOs.CategoryDTO;

namespace CatalogService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCategory(CategoryAddDTO categoryAddDTO)
        {
            var result = _categoryService.Add(categoryAddDTO);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAllCategories()
        {
            var result = _categoryService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}