namespace BoardGameScorer.Domain.Models;
public class TileManager
{
	private readonly Dictionary<Terrain, int> _terrainCounts;
	private readonly Dictionary<Terrain, int> _crownCounts;
	private readonly Dictionary<Terrain, int> _maxTilesPerTerrain;
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
		if (!_terrainCounts.TryGetValue(terrain, out int value))
		{
			value = 0;
			_terrainCounts[terrain] = value;
			_crownCounts[terrain] = 0;
		}

		int newTerrainCount = value + tiles;

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
