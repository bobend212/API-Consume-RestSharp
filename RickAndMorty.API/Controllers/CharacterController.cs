using Microsoft.AspNetCore.Mvc;
using RickAndMorty.API.Models;
using RickAndMorty.API.Services;

namespace RickAndMorty.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IRickMortyService _rickMortyService;

        public CharacterController(IRickMortyService rickMortyService)
        {
            _rickMortyService = rickMortyService;
        }

        [HttpGet]
        public async Task<ActionResult<CharacterModel>> GetCharactersAsync()
        {
            return Ok(await _rickMortyService.GetAllCharacters());
        }

        [HttpGet("search")]
        public async Task<ActionResult<CharacterModel>> GetCharactersSearchAsync(string search)
        {
            var result = await _rickMortyService.SearchCharactersByName(search);

            if (result.results is null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingleCharacterAsync(int id)
        {
            return Ok(await _rickMortyService.GetSingleCharacter(id));
        }
    }
}