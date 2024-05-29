namespace BoardGameScorer.Application.Services.Kingdomino;
public class GameService(IEntityRepository<Game> gameRepository)
{
    public Task<List<Game>> GetAllAsync()
    {
        return gameRepository.GetAllAsync();
    }
}
