using System.Collections.Generic;
using UnityEngine;

public class NotificationLoader : MonoBehaviour
{
	private static List<int> listLevelID;

	private static Dictionary<int, NotificationOriData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static NotificationOriData GetNotificationOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, NotificationOriData> GetAllNotificationOriData()
	{
		return null;
	}
}
