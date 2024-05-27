namespace BoardGameScorer.Application.Interfaces.Repositories;
public interface IGameService<T>
{
    List<T> GetPlayers();
    void AddPlayers(T item);
    T GetPlayerById(int itemId);
    void UpdatePlayer(T item);
}
