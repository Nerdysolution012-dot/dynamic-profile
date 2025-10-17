using DynamicProfileEndpoint.API.Data;

namespace DynamicProfileEndpoint.API.Result
{
    public class APIResponse
    {
     

      
            public string Status { get; set; } = "success";
            public User User { get; set; } = new();
            public string Timestamp { get; set; } = string.Empty;
            public string Fact { get; set; } = string.Empty;
        
    }
}
