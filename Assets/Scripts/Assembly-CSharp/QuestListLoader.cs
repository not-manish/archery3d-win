using System.Collections.Generic;
using UnityEngine;

public class QuestListLoader : MonoBehaviour
{
	private static List<int> listQuestList;

	private static Dictionary<int, QuestListOriData> oriDatas;

	public static int maxQuestNumber;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetQuestLists()
	{
		return null;
	}

	public static QuestListOriData GetQuestListOriData(int level)
	{
		return null;
	}

	public static Dictionary<int, QuestListOriData> GetAllQuestListOriData()
	{
		return null;
	}
}
