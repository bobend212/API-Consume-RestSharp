namespace RickAndMorty.API.Services
{
    public interface IRonSwansonService
    {
        Task<List<string>> GetAllSwansonQuotes(int amount);
    }
}
