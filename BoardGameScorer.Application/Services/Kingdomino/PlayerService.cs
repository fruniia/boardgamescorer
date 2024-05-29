namespace BoardGameScorer.Application.Services.Kingdomino;
public class PlayerService(IEntityRepository<Player> playerRepository)
{
    public Task<List<Player>> GetAllAsync()
    {
        return playerRepository.GetAllAsync();
    }

    public Task<Player> GetByIdAsync(int id)
    {
        return playerRepository.GetByIdAsync(id);
    }
}
