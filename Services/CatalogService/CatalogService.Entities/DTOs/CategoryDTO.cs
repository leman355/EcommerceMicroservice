using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    // CategoryName : "Value"   pascal case olmamalidi
    // category_name : "Value"  snake case olmalidi
    public class CategoryDTO
    {
        public record CategoryAddDTO(string CategoryName, List<string> SubCategoryId);
        public record CategoryRemoveDTO(string Id);
        //public record CategoryListDTO(string CategoryName, List<string> SubCategoryName);
    }
}