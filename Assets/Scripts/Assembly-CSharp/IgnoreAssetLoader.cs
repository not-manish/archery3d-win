using System.Collections.Generic;

public class IgnoreAssetLoader
{
	private static List<int> listLevelID;

	private static Dictionary<int, IgnoreAssetOriData> oriDatas;

	public static void LoadData()
	{
	}

	public static List<int> GetLevelKindIDs()
	{
		return null;
	}

	public static IgnoreAssetOriData GetIgnoreAssetOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, IgnoreAssetOriData> GetAllIgnoreAssetOriData()
	{
		return null;
	}

	public static bool CheckIsIgnoreAsset(string urlDownload, string md5)
	{
		return false;
	}
}
