using CorePackage.DataAccess.EntityFramework;
using OrderService.DataAccess.Abstract;
using OrderService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.DataAccess.Concrete.EntityFramework
{
    public class OrderItemDal : EfRepositoryBase<OrderItem, OrderDbContext>, IOrderItemDal
    {
    }
}
