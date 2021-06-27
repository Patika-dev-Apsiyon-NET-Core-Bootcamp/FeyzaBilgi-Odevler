using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Results;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(RegisterViewModel userForRegisterDto,string password);
        IDataResult<User> Login(LoginViewModel userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
