using BasketService.Entities.Concrete;
using BasketService.Entities.DTOs;
using CorePackage.DataAccess;
using CorePackage.Helpers.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DataAccess.Abstract
{
    public interface IBasketDal : IRepositoryBase<Basket>
    {
        IDataResult<BasketListDTO> GetBasketByUserId(string userId);
    }
}