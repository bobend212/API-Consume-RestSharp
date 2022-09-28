using RickAndMorty.API.Models;

namespace RickAndMorty.API.Services
{
    public class RonSwansonService : IRonSwansonService
    {
        private readonly RestClient _client;
        private const string baseUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        public RonSwansonService()
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<List<string>> GetAllSwansonQuotes(int amount)
        {
            List<string> model;
            try
            {
                var request = new RestRequest($"{amount}");
                model = await _client.GetAsync<List<string>>(request);
            }
            catch (Exception ex)
            {
                throw;
            }

            return model!;
        }
    }
}
