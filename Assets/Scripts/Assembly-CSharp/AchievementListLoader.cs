using System.Collections.Generic;

public class AchievementListLoader
{
	private static List<int> listAchievementList;

	private static Dictionary<int, AchievementListOriData> oriDatas;

	private static Dictionary<int, AchievementListRealtimeData> realtimeDatas;

	private static Dictionary<int, List<AchievementListOriData>> realtimeBigTypeDatas;

	private static Dictionary<int, AchievementListOriData> realtimeSmallTypeDatas;

	private static Dictionary<int, Dictionary<int, AchievementListOriData>> oriSmallTypeDatas;

	private static int total_arena_games;

	public static int TotalArenaGames
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static void LoadAchievementListRealtimeData()
	{
	}

	public static List<int> GetAchievementListIDs()
	{
		return null;
	}

	public static AchievementListOriData GetAchievementListOriData(int level)
	{
		return null;
	}

	public static Dictionary<int, AchievementListOriData> GetAllAchievementListOriData()
	{
		return null;
	}

	public static AchievementListRealtimeData GetAchievementListRealtimeData(int ID)
	{
		return null;
	}

	public static Dictionary<int, AchievementListRealtimeData> GetAllAchievementListRealtimeData()
	{
		return null;
	}

	public static Dictionary<int, List<AchievementListOriData>> GetAllAchievementListRealtimeBigTypeDatas()
	{
		return null;
	}

	public static int GetSmallTypeMaxLevel(int smallType)
	{
		return 0;
	}

	public static AchievementListOriData GetAchievementListOriData(int smallType, int Level)
	{
		return null;
	}

	public static void SetBigType(List<int> smallLevels, List<int> Levels)
	{
	}

	public static int GetRealAchievementPoint(AchievementType achievementType)
	{
		return 0;
	}

	public static int GetAchievementPoint(int bigType = 0)
	{
		return 0;
	}

	public static void SetAchievementPoint(int ID)
	{
	}
}
