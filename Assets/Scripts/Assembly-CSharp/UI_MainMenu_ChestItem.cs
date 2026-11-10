using UnityEngine;

public class UI_MainMenu_ChestItem : MonoBehaviour
{
	[HideInInspector]
	private int index;

	public UI_MainMenu_ChestItem_Empty uiEmpty;

	public UI_MainMenu_ChestItem_Locked uiLocked;

	public UI_MainMenu_ChestItem_TimeLeft uiTimeLeft;

	public UI_MainMenu_ChestItem_Ready uiReady;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private UnLockGameModeLevel unLockGameModeLevel;

	public UI_AnimationCtrl uiChestAnimationCtrl;

	private PlayerData playerData;

	public void Show(int _index)
	{
	}

	public void UpdateState(ChestListType chestListType = ChestListType.Null)
	{
	}

	public void SaveNewChestData(int index)
	{
	}

	public bool GetNewChestState(int indexNum)
	{
		return false;
	}

	private void Update()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}
}
