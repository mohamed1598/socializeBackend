using Microsoft.AspNetCore.Identity;
using Socialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<IdentityResult> Register(User user);
        Task<SignInResult> Login(User user);
        Task<User> GetUserByEmail(string email);
    }
}
