using System.Collections.Generic;
using UnityEngine;

public class QuestScoreRewardLoader : MonoBehaviour
{
	private static List<int> listQuestScoreReward;

	private static List<int> listQuestRondIndex;

	private static Dictionary<int, QuestScoreRewardOriData> oriDatas;

	private static QuestScoreRewardRealtimeData realtimeDatas;

	private static Dictionary<int, Dictionary<int, QuestScoreRewardOriData>> realtimeBigTypeDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static void LoadQuestScoreRewardtimeData()
	{
	}

	public static List<int> GetQuestScoreRewards()
	{
		return null;
	}

	public static QuestScoreRewardOriData GetQuestScoreRewardOriData(int level)
	{
		return null;
	}

	public static Dictionary<int, QuestScoreRewardOriData> GetAllQuestScoreRewardOriData()
	{
		return null;
	}

	public static QuestScoreRewardRealtimeData GetQuestScoreRewardRealtimeData()
	{
		return null;
	}

	public static Dictionary<int, Dictionary<int, QuestScoreRewardOriData>> GetAllQuestScoreRewardBigTypeDatas()
	{
		return null;
	}

	public static QuestScoreRewardOriData GetQuestScoreRewardBigTypeDatas(int round_type, int reward_type)
	{
		return null;
	}

	public static int GetRoundType()
	{
		return 0;
	}

	public static bool GetQuestScoreReward(int score = 0)
	{
		return false;
	}
}
