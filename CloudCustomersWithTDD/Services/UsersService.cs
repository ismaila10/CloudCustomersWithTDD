using CloudCustomersAPIWithTDD.Models;

namespace CloudCustomersAPIWithTDD.Services
{
    public class UsersService : IUsersService
    {
        public UsersService()
        {

        }

        Task<List<User>> IUsersService.GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
