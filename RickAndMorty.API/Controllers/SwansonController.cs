using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.API.Models;
using RickAndMorty.API.Services;

namespace RickAndMorty.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwansonController : ControllerBase
    {
        private readonly IRonSwansonService _ronSwansonService;

        public SwansonController(IRonSwansonService ronSwansonService)
        {
            _ronSwansonService = ronSwansonService;
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> GetSwansonQuotes(int amount)
        {
            return Ok(await _ronSwansonService.GetAllSwansonQuotes(amount));
        }
    }
}
