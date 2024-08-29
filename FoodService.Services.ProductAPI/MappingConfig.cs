using AutoMapper;
using FoodService.Services.ProductAPI.Models;
using FoodService.Services.ProductAPI.Models.Dto;

namespace FoodService.Services.ProductAPI
{
    public class MappingConfig
    {
        public static  MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
