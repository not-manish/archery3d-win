using System.Collections.Generic;
using UnityEngine;

public class UI_MainMenu_ChestList : MonoBehaviour
{
	private enum ChestState
	{
		Null = 0,
		Normal = 1,
		PlayNewChest = 2
	}

	public UI_MainMenu_ChestItem[] uiChestLists;

	public List<int> uiNewChestLists;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private float AnimTime;

	private ChestState chestState;

	private int Addindex;

	public void Show()
	{
	}

	public void PlayerAnim(ChestListType chestListType = ChestListType.Null)
	{
	}

	public void UpdateState(ChestListType chestListType = ChestListType.Null)
	{
	}

	private void Update()
	{
	}

	public void GetShowAnimCount()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}
}
