using RickAndMorty.API.Models;

namespace RickAndMorty.API.Services
{
    public interface IRickMortyService
    {
        Task<CharacterModel> GetAllCharacters();

        Task<CharacterModel> SearchCharactersByName(string search);

        Task<Character> GetSingleCharacter(int id);
    }
}