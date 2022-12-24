using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using OrderService.Business.Abstract;
using OrderService.Entities.DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace OrderService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;

        public OrderController(IOrderService orderService, IOrderItemService orderItemService)
        {
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        [HttpPost("addOrder")]
        public IActionResult AddOrder(List<OrderItemDTO> orderItem)
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            var result = _orderItemService.Add(orderItem, id);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);
        }


        [HttpGet("getorder")]
        public IActionResult GetOrder()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var id = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;

            var result = _orderService.GetOrderByUserId(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
