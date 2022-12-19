using BasketService.Business.Abstract;
using BasketService.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;

namespace BasketService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IBasketItemService _basketItemService;

        public BasketController(IBasketService basketService, IBasketItemService basketItemService)
        {
            _basketService = basketService;
            _basketItemService = basketItemService;
        }

        [HttpPost("addtocart")]
        public IActionResult AddToCard(List<BasketItemDTO> basketItem)
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            var result = _basketItemService.Add(basketItem, id);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);
        }

        [HttpGet("getbasket")]
        public IActionResult GetBasket()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;

            var result = _basketService.GetBasketByUserId(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}