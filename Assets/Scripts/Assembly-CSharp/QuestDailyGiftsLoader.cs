using System.Collections.Generic;
using UnityEngine;

public class QuestDailyGiftsLoader : MonoBehaviour
{
	private static List<int> listQuestDailyGifts;

	private static Dictionary<int, List<QuestDailyGiftsOriData>> Round_indexDatas;

	private static Dictionary<int, QuestDailyGiftsOriData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetQuestDailyGifts()
	{
		return null;
	}

	public static QuestDailyGiftsOriData GetQuestDailyGiftsOriData(int id)
	{
		return null;
	}

	public static Dictionary<int, QuestDailyGiftsOriData> GetAllQuestDailyGiftsOriData()
	{
		return null;
	}

	public static List<QuestDailyGiftsOriData> GetAllQuestDailyGiftsRound_indexDatas(int roundIndex)
	{
		return null;
	}

	public static List<QuestDailyGiftsOriData> GetRangeDailyGifts()
	{
		return null;
	}
}
