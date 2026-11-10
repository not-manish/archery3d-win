using System.Collections.Generic;

public class LevelArenaTargetsLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, LevelArenaTargetsOriData> oriDatas;

	private static Dictionary<int, Dictionary<int, LevelArenaTargetsOriData>> levelIdIndexOriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static LevelArenaTargetsOriData GetLevelArenaTargetsOriData(int ID)
	{
		return null;
	}

	public static bool ContainKey(int ID)
	{
		return false;
	}

	public static LevelArenaTargetsOriData GetLevelArenaTargetsOriData(int LevelId, int LevelIndex)
	{
		return null;
	}

	public static ScanMinMaxInt GetLevelRangeRange(int LevelId)
	{
		return null;
	}

	public static ScanMinMaxFloat GetLevelWindRange(int LevelId)
	{
		return null;
	}
}
