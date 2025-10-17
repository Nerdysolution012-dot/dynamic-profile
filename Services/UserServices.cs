using DynamicProfileEndpoint.API.Data;

namespace DynamicProfileEndpoint.API.Services
{
    public class UserServices
    {
   

        public async Task<List<User>>  GetUsers()
        {
            return InMemoryDatabase.Profiles;
        }
    }
}
