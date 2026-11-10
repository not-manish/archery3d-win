using System.Collections.Generic;
using UnityEngine;

public class UI_Level1v1_Info : MonoBehaviour
{
	public UILabel lRentalFee;

	public UILabel lRange;

	public UILabel lWindRange;

	public UI_Level1v1_Info_Chest uiInfoChest;

	public UI_Level1V1_Rule uiLevel1V1Rule;

	public void UpdateState(GameType gameType, int levelID)
	{
	}

	private void UpdateState_Classic(GameType gameType, int levelID)
	{
	}

	private void UpdateState_Rush(GameType gameType, int levelID)
	{
	}

	private void UpdateState_Bingo(GameType gameType, int levelID)
	{
	}

	public void SetTargetRange(ScanMinMaxInt rangeRange)
	{
	}

	public void SetWindRange(ScanMinMaxFloat rangeRange)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void Hide()
	{
	}

	public List<int> GetChestIds(int levelGrade)
	{
		return null;
	}

	private int GetChestClassicIdByMaterialGrade(int ChestMaterial, int ChestGrade)
	{
		return 0;
	}
}
