using System.Collections.Generic;

public class LevelBingoTargetsLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, LevelBingoTargetsOriData> oriDatas;

	private static Dictionary<int, Dictionary<int, LevelBingoTargetsOriData>> levelIdIndexOriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static LevelBingoTargetsOriData GetLevelBingoTargetsOriData(int ID)
	{
		return null;
	}

	public static bool ContainKey(int ID)
	{
		return false;
	}

	public static LevelBingoTargetsOriData GetLevelBingoTargetsOriData(int LevelId, int LevelIndex)
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
