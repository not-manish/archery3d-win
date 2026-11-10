using System.Collections.Generic;
using UnityEngine;

public class DailyGiftsLoader : MonoBehaviour
{
	private static List<int> listDailyGifts;

	private static Dictionary<int, DailyGiftsData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetDailyGifts()
	{
		return null;
	}

	public static DailyGiftsData GetDailyGiftsOriData(int id)
	{
		return null;
	}

	public static Dictionary<int, DailyGiftsData> GetAllDailyGiftsOriData()
	{
		return null;
	}
}
