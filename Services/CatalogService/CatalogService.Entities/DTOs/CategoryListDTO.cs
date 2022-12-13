using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    public class CategoryListDTO
    {
        public string CategoryName { get; set; }
        public List<string> SubCategoryName { get; set; }
    }
}
