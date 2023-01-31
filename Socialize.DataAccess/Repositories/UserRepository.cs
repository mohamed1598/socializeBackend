using Microsoft.AspNetCore.Identity;
using Socialize.DataAccess.Repositories.IRepositories;
using Socialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public UserRepository(SignInManager<User> signInManager,UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<SignInResult> Login(User user)
        {
            var realUser = await GetUserByEmail(user.Email);
            var result = await _signInManager.PasswordSignInAsync(realUser.UserName, user.PasswordHash, false, lockoutOnFailure: false);
            return result;
        }

        public async Task<IdentityResult> Register(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(user,user.PasswordHash);
            return result;
        }
    }
}
