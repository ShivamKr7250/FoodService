﻿using FoodService.Services.AuthAPI.Models.Dto;

namespace FoodService.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);

        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);   
    }
}
