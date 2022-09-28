using RickAndMorty.API.Models;

namespace RickAndMorty.API.Services
{
    public class RickMortyService : IRickMortyService
    {
        private readonly RestClient _client;
        private const string baseUrl = "https://rickandmortyapi.com/api/";

        public RickMortyService()
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<CharacterModel> GetAllCharacters()
        {
            CharacterModel model;

            try
            {
                var request = new RestRequest("character");
                model = await _client.GetAsync<CharacterModel>(request);
            }
            catch (Exception ex)
            {
                throw;
            }

            return model!;
        }

        public async Task<CharacterModel> SearchCharactersByName(string search)
        {
            CharacterModel model;

            try
            {
                var request = new RestRequest("character").AddParameter("name", search);
                model = await _client.GetAsync<CharacterModel>(request);
            }
            catch (Exception ex)
            {
                throw;
            }

            return model!;
        }

        public async Task<Character> GetSingleCharacter(int id)
        {
            Character model;

            try
            {
                var request = new RestRequest($"character/{id}");
                model = await _client.GetAsync<Character>(request);
            }
            catch (Exception ex)
            {
                throw;
            }

            return model!;
        }
    }
}