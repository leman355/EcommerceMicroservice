using BasketService.Business.Abstract;
using BasketService.DataAccess.Abstract;
using BasketService.Entities.Concrete;
using BasketService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public IResult AddBasket(BasketAddDTO basketAddDTO)
        {
            try
            {
                var findBasket = _basketDal.Get(x => x.UserId == basketAddDTO.UserId);
                if (findBasket != null)
                    return new ErrorResult("Bu sebet artiq movcuddur.");

                Basket newBasket = new()
                {
                    UserId = basketAddDTO.UserId,
                };
                _basketDal.Add(newBasket);
                return new SuccessResult("Sebet yaradildi.");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<BasketListDTO> GetBasketByUserId(string userId)
        {
            try
            {
                var result = _basketDal.GetBasketByUserId(userId);
                return result;
            }
            catch (Exception e)
            {
                return new ErrorDataResult<BasketListDTO>(e.Message);
            }
        }
    }
}