using BeerMaker.Models.Auth;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Services
{
    public interface IUserService
    {
        Task<JsonWebToken> CreateSecurityToken(Account account);
        Account Authenticate(string username, string password);
    }

    public class UserService : IUserService
    {
        public Account Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<JsonWebToken> CreateSecurityToken(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
