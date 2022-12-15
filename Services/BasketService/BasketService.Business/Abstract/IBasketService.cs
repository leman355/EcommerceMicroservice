using BasketService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.Business.Abstract
{
    public interface IBasketService
    {
        IResult AddBasket(BasketAddDTO basketAddDTO);
        IDataResult<BasketListDTO> GetBasketByUserId(string userId);
    }
}