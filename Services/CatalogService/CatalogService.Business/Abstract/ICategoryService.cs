using CatalogService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
    }
}