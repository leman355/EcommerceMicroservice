using BasketService.DataAccess.Abstract;
using BasketService.Entities.Concrete;
using BasketService.Entities.DTOs;
using CorePackage.DataAccess.EntityFramework;
using CorePackage.Helpers.Result.Abstract;
using CorePackage.Helpers.Result.Concrete.SuccessResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DataAccess.Concrete.EntityFramework
{
    public class BasketDal : EfRepositoryBase<Basket, BasketDbContext>, IBasketDal
    {
        public IDataResult<BasketListDTO> GetBasketByUserId(string userId)
        {
            using (BasketDbContext _context = new())
            {
                var findUserBasket = _context.Baskets.Include(x => x.BasketItems).FirstOrDefault(x => x.UserId == userId);
                List<BasketItemDTO> basketItems = new();
                foreach (var item in findUserBasket.BasketItems)
                {
                    BasketItemDTO basketItemDTO = new()
                    {
                        BasketId = item.Id,
                        Price = item.Price,
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Quantity = item.Quantity
                    };
                    basketItems.Add(basketItemDTO);
                }
                BasketListDTO basket = new()
                {
                    Id = findUserBasket.Id,
                    UserId = findUserBasket.UserId,
                    BasketItems = basketItems
                };
                return new SuccessDataResult<BasketListDTO>(basket);
            }
        }
    }
}