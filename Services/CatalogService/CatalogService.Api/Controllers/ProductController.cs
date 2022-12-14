using CatalogService.Business.Abstract;
using CatalogService.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("gethomeall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetHomeProducts();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductDTO productDTO)
        {
            var addData = _productService.AddProduct(productDTO);
            if (!addData.Success)
            {
                return BadRequest(addData.Message);
            }
            return Ok(addData.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetProductsById(string Id)
        {
            var result = _productService.GetHomeProducts();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}