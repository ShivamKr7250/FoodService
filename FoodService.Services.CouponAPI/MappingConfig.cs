using AutoMapper;
using FoodService.Services.CouponAPI.Models;
using FoodService.Services.CouponAPI.Models.Dto;

namespace FoodService.Services.CouponAPI
{
    public class MappingConfig
    {
        public static  MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
