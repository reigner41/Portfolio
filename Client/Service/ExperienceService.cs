using PortfolioWithServer.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PortfolioWithServer.Client.Services
{
    public class ExperienceService
    {
        private readonly HttpClient _httpClient;

        public ExperienceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Experience>> GetExperiencesAsync()
        {
            var response = await _httpClient.GetAsync("api/Experience");
            if (response?.Content != null)
            {
                return await response.Content.ReadFromJsonAsync<List<Experience>>() ?? new List<Experience>();
            }
            return new List<Experience>();
        }
    }
}