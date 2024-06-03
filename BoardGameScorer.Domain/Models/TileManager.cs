namespace BoardGameScorer.Domain.Models;
public class TileManager
{
	private Dictionary<Terrain, int> _terrainCounts;
	private Dictionary<Terrain, int> _crownCounts;
	private Dictionary<Terrain, int> _maxTilesPerTerrain;
	public TileManager()
	{
		_terrainCounts = [];
		_crownCounts = [];
		_maxTilesPerTerrain = new Dictionary<Terrain, int>
		{
			[Terrain.Wheat] = (int)Terrain.Wheat,
			[Terrain.Forest] = (int)Terrain.Forest,
			[Terrain.Lake] = (int)Terrain.Lake,
			[Terrain.Grassland] = (int)Terrain.Grassland,
			[Terrain.Swamp] = (int)Terrain.Swamp,
			[Terrain.Mine] = (int)Terrain.Mine
		};
	}

	public bool AddTile(Terrain terrain, int crowns, int tiles)
	{
		if (!_terrainCounts.ContainsKey(terrain))
		{
			_terrainCounts[terrain] = 0;
			_crownCounts[terrain] = 0;
		}

		int newTerrainCount = _terrainCounts[terrain] + tiles;

		if (newTerrainCount > _maxTilesPerTerrain[terrain])
		{
			return false;
		}
		else
		{
			_terrainCounts[terrain] = newTerrainCount;
			_crownCounts[terrain] += crowns;
			return true;
		}
	}
}
