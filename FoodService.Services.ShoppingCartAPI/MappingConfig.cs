using AutoMapper;
using FoodService.Services.ShoppingCartAPI.Models;
using FoodService.Services.ShoppingCartAPI.Models.Dto;

namespace FoodService.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static  MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
