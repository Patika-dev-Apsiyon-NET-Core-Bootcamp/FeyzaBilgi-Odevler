using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using CleanArchitecture.Application.Hashing;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Results;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class AuthService : IAuthService
    {
        private IUserRepository _userService;
        private ITokenHelper _tokenHelper;

        public AuthService(IUserRepository userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(LoginViewModel userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Register(RegisterViewModel userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user);
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}