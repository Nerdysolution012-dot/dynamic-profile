namespace DynamicProfileEndpoint.API.Data
{
    public class InMemoryDatabase
    {
        public static List<User> Profiles { get; set; } = new()
        {
             new User()
             {
                    Id = 1,
                    Email = "Muizmabamidu@gmail.com",
                    Name = "Mabamidu Muiz",
                    Stack = "Backend Developer"
             }
        };
    }
}
