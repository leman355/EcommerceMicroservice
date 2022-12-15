using BasketService.Entities.Concrete;
using CorePackage.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DataAccess.Abstract
{
    public interface IBasketItemDal : IRepositoryBase<BasketItem>
    {
    }
}