using AutoMapper;
using CatalogService.Entities.Concrete;
using CatalogService.Entities.DTOs;
using static CatalogService.Entities.DTOs.CategoryDTO;
using static CatalogService.Entities.DTOs.SubCategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryAddDTO>().ReverseMap();
            CreateMap<Category, CategoryRemoveDTO>().ReverseMap();
            CreateMap<Category, CategoryListDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductListDTO>().ReverseMap();

            CreateMap<Feature, FeatureDTO>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueDTO>().ReverseMap();


            CreateMap<SubCategory, SubCategoryAddDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryListDTO>().ReverseMap();
        }
    }
}