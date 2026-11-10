using System.Collections.Generic;

public class LevelChongCiTargetsLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, LevelChongCiTargetsOriData> oriDatas;

	private static Dictionary<int, Dictionary<int, LevelChongCiTargetsOriData>> levelIdIndexOriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static LevelChongCiTargetsOriData GetLevelChongCiTargetsOriData(int ID)
	{
		return null;
	}

	public static bool ContainKey(int ID)
	{
		return false;
	}

	public static LevelChongCiTargetsOriData GetLevelChongCiTargetsOriData(int LevelId, int LevelIndex)
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
