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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult AddOrder(OrderAddDTO orderAddDTO)
        {
            try
            {
                var findorder = _orderDal.Get(x => x.UserId == orderAddDTO.UserId);
                if (findorder != null)
                    return new ErrorResult("Order movcuddur");
                Order newOrder = new()
                {
                    UserId = orderAddDTO.UserId,
                };
                _orderDal.Add(newOrder);
                return new SuccessResult("Order yarandi");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<OrderListDTO> GetOrderByUserId(string userId)
        {
            try
            {
                var result = _orderDal.GetOrderByUserId(userId);
                return result;
            }
            catch (Exception e)
            {
                return new ErrorDataResult<OrderListDTO>(e.Message);
            }
        }
    }
}
