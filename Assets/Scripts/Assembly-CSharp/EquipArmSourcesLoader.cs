using System.Collections.Generic;

public class EquipArmSourcesLoader
{
	private static List<int> listArmsID;

	private static Dictionary<int, EquipArmSourcesOriData> oriDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetArmsKindIDs()
	{
		return null;
	}

	public static bool ContainKey(int ID)
	{
		return false;
	}

	public static EquipArmSourcesOriData GetEquipArmSourcesOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, EquipArmSourcesOriData> GetAllEquipArmSourcesOriData()
	{
		return null;
	}

	public static EquipArmSourcesOriData GetNearArmModelNameByIndex(ref int ModelId)
	{
		return null;
	}
}
