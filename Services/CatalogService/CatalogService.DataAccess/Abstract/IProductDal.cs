using CatalogService.Entities.Concrete;
using CorePackage.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
    }
}
