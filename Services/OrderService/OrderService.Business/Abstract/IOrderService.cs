using CorePackage.Helpers.Result.Abstract;
using OrderService.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Business.Abstract
{
    public interface IOrderService
    {
        IResult AddOrder(OrderAddDTO orderAddDTO);
        IDataResult<OrderListDTO> GetOrderByUserId(string userId);
    }
}
