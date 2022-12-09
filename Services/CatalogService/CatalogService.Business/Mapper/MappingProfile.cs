using AutoMapper;
using CatalogService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatalogService.Entities.DTOs.CategoryDTO;
using static CatalogService.Entities.DTOs.ProductDTO;
using static CatalogService.Entities.DTOs.SubCategoryDTO;

namespace CatalogService.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryAddDTO>().ReverseMap();
            CreateMap<Category, CategoryRemoveDTO>().ReverseMap();
            CreateMap<Category, CategoryListDTO>().ReverseMap();

            CreateMap<Product, ProductAddDTO>().ReverseMap();
            CreateMap<Product, ProductGetByIdDTO>().ReverseMap();

            CreateMap<SubCategory, SubCategoryAddDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryListDTO>().ReverseMap();
        }
    }
}
