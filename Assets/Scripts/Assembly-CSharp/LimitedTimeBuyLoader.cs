using System.Collections.Generic;
using UnityEngine;

public class LimitedTimeBuyLoader : MonoBehaviour
{
	private static List<int> listLimitedTimeBuys;

	private static Dictionary<int, List<LimitedTimeBuyOriData>> Round_indexDatas;

	private static Dictionary<int, LimitedTimeBuyOriData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLimitedTimeBuys()
	{
		return null;
	}

	public static LimitedTimeBuyOriData GetLimitedTimeBuysOriData(int id)
	{
		return null;
	}

	public static Dictionary<int, LimitedTimeBuyOriData> GetAllLimitedTimeBuysOriData()
	{
		return null;
	}

	public static int GetLimitedTimeBuysChallengeIndex(ChallengeGroup group)
	{
		return 0;
	}

	public static bool IsLimitedTimeBuyDifferentAB(int id)
	{
		return false;
	}

	public static int GetLimitedTimeBuyUITypeId(int id)
	{
		return 0;
	}

	public static int GetLimitedTimeBuysLeagueIndex(int segment)
	{
		return 0;
	}

	public static int GetLimitedTimeBuysNewPlayerIndex(int grade)
	{
		return 0;
	}

	public static bool isShowNewPlayerLimited(NewPlayerLimitedID newPlayerLimitedID)
	{
		return false;
	}
}
