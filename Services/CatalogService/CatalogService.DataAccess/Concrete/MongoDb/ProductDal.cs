using CatalogService.DataAccess.Abstract;
using CatalogService.Entities.Concrete;
using CorePackage.DataAccess.MongoDB;
using CorePackage.DataAccess.MongoDB.MongoSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Concrete.MongoDb
{
    public class ProductDal : MongoRepositoryBase<Product>, IProductDal
    {
        public ProductDal(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
