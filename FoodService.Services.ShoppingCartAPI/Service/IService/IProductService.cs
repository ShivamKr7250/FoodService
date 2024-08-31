using FoodService.Services.ShoppingCartAPI.Models.Dto;

namespace FoodService.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
