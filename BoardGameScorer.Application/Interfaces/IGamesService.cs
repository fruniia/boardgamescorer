﻿namespace BoardGameScorer.Application.Interfaces;
public interface IGamesService<T>
{
	List<T> GetPlayers();
	void AddPlayers(T item);
	T GetPlayerById(int itemId);
	void UpdatePlayer(T item);
	void SetPlayers(List<T> items);
}
