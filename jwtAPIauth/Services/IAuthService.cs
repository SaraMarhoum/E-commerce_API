using jwtAPIauth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthModel> CreateUser(RegisterModel model);
        Task<IEnumerable<ApplicationUser>> GetUsers();
        Task EditUser(ApplicationUser user);
        Task<ApplicationUser> GetUser(string id);
        Task DeleteUser(string id);
    }
}
