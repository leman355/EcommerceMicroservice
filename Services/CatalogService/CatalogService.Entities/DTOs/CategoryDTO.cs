using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    // CategoryName : "Ehmed"   pascal case olmamalidi
    // category_name : "Ehmed"   snake case olmalidi
    public class CategoryDTO
    {
        public record CategoryAddDTO(string CategoryName, List<string> SubCategoryId);
        public record CategoryRemoveDTO(string Id);
        public record CategoryListDTO(string CategoryName, List<string> SubCategoryName);

    }
}