using CorePackage.DataAccess.EntityFramework;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using Microsoft.EntityFrameworkCore;
using OrderService.DataAccess.Abstract;
using OrderService.Entities.Concrete;
using OrderService.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EfRepositoryBase<Order, OrderDbContext>, IOrderDal
    {
        public IDataResult<OrderListDTO> GetOrderByUserId(string userId)
        {
            using (OrderDbContext _context = new())
            {
                var findUser = _context.Orders.Include(x => x.OrderItems).FirstOrDefault(x => x.UserId == userId);
                List<OrderItemDTO> orderItems = new();
                foreach (var item in findUser.OrderItems)
                {
                    OrderItemDTO orderItemDTO = new()
                    {
                        ProductName = item.ProductName,
                    };
                    orderItems.Add(orderItemDTO);
                }
                OrderListDTO order = new()
                {
                    Id = findUser.Id,
                    UserId = findUser.UserId,
                };

                return new SuccessDataResult<OrderListDTO>(order);
            }
        }
    }
}
