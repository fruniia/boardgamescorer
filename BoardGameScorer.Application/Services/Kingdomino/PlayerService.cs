namespace BoardGameScorer.Application.Services.Kingdomino;
public class PlayerService(IPlayerRepository playerRepository)
{
    public Task<List<Player>> GetAllAsync()
    {
        return playerRepository.GetAllAsync();
    }

    public Task<Player> GetByIdAsync(int id)
    {
        return playerRepository.GetByIdAsync(id);
    }

    public Task<List<Player>> GetPlayerByPlaySessionId(int playsessionId)
    {
        return playerRepository.GetPlayerByPlaySessionId(playsessionId);
    }
}
