using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    public class SubCategoryDTO
    {
        public record SubCategoryAddDTO(string SubCategoryName);
        public record SubCategoryRemoveDTO(string Id);
        public record SubCategoryListDTO(string SubCategoryName);

    }
}
