using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using OrderService.Business.Abstract;
using OrderService.DataAccess.Abstract;
using OrderService.Entities.Concrete;
using OrderService.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Business.Concrete
{
    public class OrderItemManager : IOrderItemService
    {
        private readonly IOrderItemDal _orderItemDal;
        private readonly IOrderService _orderService;

        public OrderItemManager(IOrderItemDal orderItemDal, IOrderService orderService)
        {
            _orderItemDal = orderItemDal;
            _orderService = orderService;
        }

        public IDataResult<List<OrderItemDTO>> Add(List<OrderItemDTO> orderItems, string userId)
        {
            try
            {
                var result = _orderService.GetOrderByUserId(userId);
                if (result.Data == null)
                {
                    OrderAddDTO orderAddDTO = new()
                    {
                        UserId = userId
                    };
                    _orderService.AddOrder(orderAddDTO);
                }
                result = _orderService.GetOrderByUserId(userId);
                foreach (var item in orderItems)
                {
                    OrderItem orderItem = new()
                    {
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                    };
                    _orderItemDal.Add(orderItem);
                }
                return new SuccessDataResult<List<OrderItemDTO>>(orderItems);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<OrderItemDTO>>(e.Message);
                throw;
            }
        }

        public IDataResult<List<OrderItemDTO>> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
