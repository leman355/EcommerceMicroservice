using CatalogService.Business.Abstract;
using CatalogService.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddCategory([FromBody]string categoryName)
        {
            try
            {
                Category newCategory = new()
                {
                    CategoryName = categoryName
                };
                _categoryService.Add(newCategory);
                return Ok();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}