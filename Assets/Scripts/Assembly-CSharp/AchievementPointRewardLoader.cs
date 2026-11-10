using System.Collections.Generic;
using UnityEngine;

public class AchievementPointRewardLoader : MonoBehaviour
{
	private static List<int> listAchievementPointList;

	private static Dictionary<int, AchievementPointRewardOriData> oriDatas;

	private static AchievementPointRewardRealtimeData realtimeDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static void LoadAchievementPointRewardRealtimeData()
	{
	}

	public static List<int> GetlistAchievementPointListIDs()
	{
		return null;
	}

	public static AchievementPointRewardOriData GetAchievementPointRewardOriData(int point)
	{
		return null;
	}

	public static Dictionary<int, AchievementPointRewardOriData> GetAllAchievementPointRewardOriData()
	{
		return null;
	}

	public static AchievementPointRewardRealtimeData GetAchievementPointRewardRealtimeData()
	{
		return null;
	}
}
