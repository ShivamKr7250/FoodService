using FoodService.Services.ShoppingCartAPI.Models.Dto;

namespace FoodService.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
