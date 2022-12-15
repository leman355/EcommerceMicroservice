using BasketService.Business.Abstract;
using BasketService.DataAccess.Abstract;
using BasketService.Entities.Concrete;
using BasketService.Entities.DTOs;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.ErrorResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.Business.Concrete
{
    public class BasketItemManager : IBasketItemService
    {
        private readonly IBasketItemDal _basketItemDal;
        private readonly IBasketService _basketService;

        public BasketItemManager(IBasketItemDal basketItemDal, IBasketService basketService)
        {
            _basketItemDal = basketItemDal;
            _basketService = basketService;
        }

        public IDataResult<List<BasketItemDTO>> Add(List<BasketItemDTO> basketItems, string userId)
        {
            try
            {
                var result = _basketService.GetBasketByUserId(userId);
                foreach (var item in basketItems)
                {
                    BasketItem basketItem = new()
                    {
                        ProductId = item.ProductId,
                        Price = item.Price,
                        ProductName = item.ProductName,
                        Quantity = item.Quantity,
                        BasketId = item.BasketId,
                    };
                }

            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<BasketItemDTO>>(e.Message);
            }
        }
        public IDataResult<List<BasketItemDTO>> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}