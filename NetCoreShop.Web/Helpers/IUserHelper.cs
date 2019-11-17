using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NetCoreShop.Web.Data.Entities;

namespace NetCoreShop.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}