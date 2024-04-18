using BlazorCrud.Data;
using BlazorCrud.Entity;

namespace BlazorCrud.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
