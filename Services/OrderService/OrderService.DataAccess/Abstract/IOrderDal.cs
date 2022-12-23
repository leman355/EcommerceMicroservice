using CorePackage.DataAccess;
using CorePackage.Helpers.Result.Abstract;
using OrderService.Entities.Concrete;
using OrderService.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.DataAccess.Abstract
{
    public interface IOrderDal : IRepositoryBase<Order>
    {
        IDataResult<OrderListDTO> GetOrderByUserId(string userId);
    }
}
