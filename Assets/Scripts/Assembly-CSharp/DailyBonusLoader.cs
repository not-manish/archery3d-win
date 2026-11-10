using System.Collections.Generic;
using UnityEngine;

public class DailyBonusLoader : MonoBehaviour
{
	private static List<int> listDailyBonus;

	private static Dictionary<int, List<DailyBonusOriData>> Round_indexDatas;

	private static Dictionary<int, DailyBonusOriData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetDailyBonus()
	{
		return null;
	}

	public static DailyBonusOriData GetDailyBonusOriData(int id)
	{
		return null;
	}

	public static Dictionary<int, DailyBonusOriData> GetAllDailyBonusOriData()
	{
		return null;
	}
}
