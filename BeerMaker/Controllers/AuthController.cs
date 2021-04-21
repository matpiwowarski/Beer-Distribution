using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMaker.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace BeerMaker.Controllers
{
    public class AuthController : Controller
    {
        public async Task<IActionResult> Authenticate(UserCredentials userCredentials)
        {
            return null;
        }
        public async Task<IActionResult> RefreshToken(Guid userId, string token)
        {
            return null;
        }
        public async Task<IActionResult> RevokeToken(Guid userId, string token)
        {
            return null;
        }
        public async Task<IActionResult> ChangePassword(Guid userId, string password, string token)
        {
            return null;
        }
        public async Task<IActionResult> ResetPassword(string email)
        {
            return null;
        }
        public async Task<IActionResult> ActivateAccount(string seed)
        {
            return null;
        }
    }
}
