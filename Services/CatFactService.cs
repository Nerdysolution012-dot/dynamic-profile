namespace DynamicProfileEndpoint.API.Services;

public class CatFactService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<CatFactService> _logger;

    public CatFactService(HttpClient httpClient, ILogger<CatFactService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<string> GetRandomCatFactAsync()
    {
        try
        {
            // Ensure 5-second timeout for safety
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            // Fetch cat fact from the required endpoint
            var response = await _httpClient.GetFromJsonAsync<CatFactResponse>("https://catfact.ninja/fact", cts.Token);


            return response?.Fact ?? "No cat fact available at the moment.";

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching cat fact from API.");
            return "Could not fetch a cat fact at this time.";
        }
    }

    // Local DTO class for Cat Facts API response
    private class CatFactResponse
    {
        public string Fact { get; set; } = string.Empty;
    }
}