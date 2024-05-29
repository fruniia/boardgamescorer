namespace BoardGameScorer.Application.Services.Kingdomino;

public class PlaySessionService(IEntityRepository<PlaySession> playSessionRepository)
{
    public Task<List<PlaySession>> GetAllAsync()
    {
        return playSessionRepository.GetAllAsync();
    }

    public Task<PlaySession> GetByIdAsync(int id)
    {
        return playSessionRepository.GetByIdAsync(id);
    }
}
