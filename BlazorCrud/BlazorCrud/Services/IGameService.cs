using BlazorCrud.Entity;

namespace BlazorCrud.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}
