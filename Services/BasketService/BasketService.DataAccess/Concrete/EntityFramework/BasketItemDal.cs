using BasketService.DataAccess.Abstract;
using BasketService.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DataAccess.Concrete.EntityFramework
{
    public class BasketItemDal : EfRepositoryBase<BasketItem, BasketDbContext>, IBasketItemDal
    {
    }
}