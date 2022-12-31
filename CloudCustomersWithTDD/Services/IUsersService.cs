using CloudCustomersAPIWithTDD.Models;

namespace CloudCustomersAPIWithTDD.Services
{
    public interface IUsersService
    {
        Task<List<User>> GetAllUsers();
    }
}
