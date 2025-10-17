namespace DynamicProfileEndpoint.API.Data
{
    public class InMemoryDatabase
    {
        public static List<User> Profiles { get; set; } = new()
        {
             new User()
             {
                    Email = "Muizmabamidu@gmail.com",
                    Name = "Mabamidu Muiz",
                    Stack = "Backend Developer"
             }
        };
    }
}
