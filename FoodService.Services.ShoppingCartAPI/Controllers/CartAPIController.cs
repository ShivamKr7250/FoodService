using AutoMapper;
using FoodService.Services.ShoppingCartAPI.Data;
using FoodService.Services.ShoppingCartAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodService.Services.ShoppingCartAPI.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartAPIController : ControllerBase
    {
        private ResponseDto _response;
        private IMapper _mapper;
        private readonly AppDbContext _db;

        public CartAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            this._response = new ResponseDto();
        }

        [HttpPost("CartUpsert")]
        public async Task<ResponseDto> Upsert(CartDto cartDto)
        {
            try
            {
                var carHeaderFromDb = await _db.CartHeaders.FirstOrDefaultAsync(u => u.UserId == cartDto.CartHeader.UserId);
                if(carHeaderFromDb == null)
                {
                    //create header and details
                }
                else
                {
                    //if header is not null
                    //check if details has same product
                    var cartDetailsFromDb = await _db.CartDetails.FirstOrDefaultAsync(
                        u => u.ProductId == cartDto.CartDetails.First().ProductId && 
                        u.CartHeaderId == carHeaderFromDb.CartHeaderId);

                    if(cartDetailsFromDb == null)
                    {
                        //create cart details

                    }
                    else
                    {
                        //update count in cart details
                    }
                }
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message.ToString();
                _response.IsSuccess = false;
            }
        }

    }
}
