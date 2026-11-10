using System.Collections.Generic;

public class LevelClassicTargetsLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, LevelClassicTargetsOriData> oriDatas;

	private static Dictionary<int, Dictionary<int, LevelClassicTargetsOriData>> levelIdIndexOriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static bool ContainKey(int ID)
	{
		return false;
	}

	public static LevelClassicTargetsOriData GetLevelClassicTargetsOriData(int ID)
	{
		return null;
	}

	public static int LevelIdAndLevelIndexToLevelTargetsID(int LevelId, int LevelIndex)
	{
		return 0;
	}

	public static LevelClassicTargetsOriData GetLevelClassicTargetsOriData(int LevelId, int LevelIndex)
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

	public static List<PvpType> GetLevelRangeRule(int LevelId)
	{
		return null;
	}
}
