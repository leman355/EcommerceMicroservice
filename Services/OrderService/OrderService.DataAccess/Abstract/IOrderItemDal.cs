using CorePackage.DataAccess;
using OrderService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.DataAccess.Abstract
{
    public interface IOrderItemDal : IRepositoryBase<OrderItem>
    {
    }
}
