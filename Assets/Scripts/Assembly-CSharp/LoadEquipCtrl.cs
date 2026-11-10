using System.Collections.Generic;
using UnityEngine;

public class LoadEquipCtrl
{
	private static string EquipAbSuffix;

	private static string EquipMatSuffix;

	private static string ArmsLocDir;

	private static string ArmsDlDir;

	private static string ArmsMaterialLocDir;

	private static string ArmsMaterialDlDir;

	private static string StabilizersLocDir;

	private static string StabilizersDlDir;

	private static string BowsLocDir;

	private static string BowsDlDir;

	private static string SightsLocDir;

	private static string SightsDlDir;

	private static string ArrowsLocDir;

	private static string ArrowsDlDir;

	private static int GetValidModelIndex(int model_index)
	{
		return 0;
	}

	public static ModelType GetPlayerModelType(int model_index)
	{
		return ModelType.male;
	}

	public static GameObject GetPlayerPrefab(int model_index)
	{
		return null;
	}

	public static GameObject GetArmModelPrefab(int model_index, Player player)
	{
		return null;
	}

	public static GameObject GetArmModelDefault(PlayerType playerType, ref int index, Player player)
	{
		return null;
	}

	private static GameObject AssembleArm(GameObject ArmObject, Material armMaterial, GameObject DecorationObject, Player player)
	{
		return null;
	}

	private static GameObject GetArmModelPrefab(string armName)
	{
		return null;
	}

	private static GameObject GetArmDecorationModelPrefab(string name)
	{
		return null;
	}

	private static Material GetArmMaterialModelPrefab(string name)
	{
		return null;
	}

	public static GameObject GetRingModelPrefab(int index, Player player)
	{
		return null;
	}

	public static GameObject GetRingModelDefault(PlayerType playerType, ref int index, Player player)
	{
		return null;
	}

	private static int GetValidRingIndex(int model_index)
	{
		return 0;
	}

	private static GameObject AssembleRing(GameObject playerRingObject, Material armMaterial, Player player)
	{
		return null;
	}

	private static GameObject GetRingPrefab(string EquipName)
	{
		return null;
	}

	private static Material GetRingMaterialPrefab(string name)
	{
		return null;
	}

	public static GameObject InstantiateBows(int index, bool isEffectBow = false)
	{
		return null;
	}

	public static GameObject GetBowDefault(PlayerType playerType, ref int index, bool isEffectBow = false)
	{
		return null;
	}

	private static int GetValidBowIndex(int model_index)
	{
		return 0;
	}

	private static GameObject GetBowPrefab(string BowName, bool isEffectBow)
	{
		return null;
	}

	public static GameObject InstantiateSights(int index)
	{
		return null;
	}

	public static GameObject GetSightDefault(PlayerType playerType, ref int index)
	{
		return null;
	}

	private static int GetValidSightIndex(int model_index)
	{
		return 0;
	}

	private static GameObject GetSightPrefab(string EquipName)
	{
		return null;
	}

	public static GameObject InstantiateArrows(int index)
	{
		return null;
	}

	public static GameObject GetArrowPrefab(PlayerType playerType, ref int index)
	{
		return null;
	}

	private static int GetValidArrowIndex(int model_index)
	{
		return 0;
	}

	private static GameObject GetArrowPrefab(string EquipName)
	{
		return null;
	}

	public static List<DownloadingTipsData> Check_IsNeedDownload_equip()
	{
		return null;
	}

	public static List<DownloadingTipsData> GetDownloadingTipsData(EquipType equipType, int modelIndex)
	{
		return null;
	}
}
