using System.Collections.Generic;

public class LevelSingleLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, LevelSingleOriData> oriDatas;

	private static Dictionary<int, LevelSingleRealtimeData> realtimeDatas;

	public static int MaxLevelID;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static void LoadLevelRealTimeData()
	{
	}

	public static void SaveLevelRealTimeData()
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static bool GetLevelMaxID(int ID)
	{
		return false;
	}

	public static LevelSingleOriData GetLevelSingleOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, LevelSingleOriData> GetAllLevelSingleOriData()
	{
		return null;
	}

	public static LevelSingleRealtimeData GetLevelSingleRealtimeData(int ID)
	{
		return null;
	}

	public static Dictionary<int, LevelSingleRealtimeData> GetAllLevelSingleRealtimeData()
	{
		return null;
	}

	public static int MaxRealTimePassLevelID()
	{
		return 0;
	}

	public static bool IsLevelUnlock(int ID)
	{
		return false;
	}

	public static bool IsLevelStarUnlock(int ID)
	{
		return false;
	}

	public static int GetNowStart()
	{
		return 0;
	}

	public static LevelPassStart CompareRealTimeDataAndOriData(int ID, int score = -1)
	{
		return LevelPassStart.NotPass;
	}
}
