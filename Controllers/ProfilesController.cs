using DynamicProfileEndpoint.API.Data;
using DynamicProfileEndpoint.API.Result;
using DynamicProfileEndpoint.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicProfileEndpoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly CatFactService _catFactService;
        private readonly ILogger<ProfilesController> _logger;

        public ProfilesController(CatFactService catFactService, ILogger<ProfilesController> logger)
        {
            _catFactService = catFactService;
            _logger = logger;
        }

        [HttpGet("/me")]
        public async Task<IActionResult> GetProfile()
        {

            _logger.LogInformation("Fetching dynamic profile with cat fact...");

            var catFact = await _catFactService.GetRandomCatFactAsync();

            var response = new APIResponse
            {
                User = new User
                {
                    Email = "MuizMabamidu@gmail.com",
                    Name = "Muiz Mabamidu",
                    Stack = "c#/Asp.netCore"
                },
                Timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"), // ISO 8601 UTC format
                
                Fact = catFact
            };

            return Ok(response);

        }

    }
}
