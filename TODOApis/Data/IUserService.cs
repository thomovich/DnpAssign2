using System.Threading.Tasks;
using TODOApis.Models;

namespace TODOApis.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string passWord);
    }
}
