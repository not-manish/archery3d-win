using UnityEngine;

public class UI_MainMenu_ChestItem_TimeLeft : MonoBehaviour
{
	public UIButton btBackground;

	public UISprite sChestIconBack;

	public UILabel lChestName1;

	public UILabel lChestName2;

	public UILabel lChestGradeNum;

	public UILabel lTimeLeft;

	public UILabel lBuyTimeCost;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public GameObject oChest;

	public UI_AnimationCtrl unMoveAnimationCtrl;

	public UILabel lWaitOpen;

	public UI_LittleTips oChestTips;

	private int ShowCount;

	public FlexibleRealTimeRegulator m_tTimeRegulatorWait;

	private int index;

	private ChestClassicSingle chestSingleData;

	private UI_MainMenu_ChestItem uiParent;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateBuyTimeCost()
	{
	}

	public static int GetChestBuyTimeCost(long timeLeftSecond)
	{
		return 0;
	}

	private void UpdateTimeLeft()
	{
	}

	public void Show(UI_MainMenu_ChestItem _uiParent, int _index, object param)
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState_Guide(int chestID)
	{
	}

	private bool IsTutorial(ChestClassicSingle chestSingle)
	{
		return false;
	}

	private void UpdateState_Classic(int chestID)
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
