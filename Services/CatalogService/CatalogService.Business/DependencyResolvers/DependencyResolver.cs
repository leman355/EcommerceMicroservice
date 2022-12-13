using CatalogService.Business.Abstract;
using CatalogService.Business.Concrete;
using CatalogService.DataAccess.Abstract;
using CatalogService.DataAccess.Concrete.MongoDb;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.DependencyResolvers
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddCustomDependencyResolver(this IServiceCollection service)
        {
            service.AddScoped<ICategoryDal, CategoryDal>();
            service.AddScoped<ICategoryService, CategoryManager>();

            service.AddScoped<ISubCategoryDal, SubCategoryDal>();
            service.AddScoped<ISubCategoryService, SubCategoryManager>();

            service.AddScoped<IProductDal, ProductDal>();
            service.AddScoped<IProductService, ProductManager>();

            return service;
        }
    }
}