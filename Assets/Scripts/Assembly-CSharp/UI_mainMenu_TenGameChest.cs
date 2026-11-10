using UnityEngine;

public class UI_mainMenu_TenGameChest : MonoBehaviour
{
	public UIButton btTenGameChest;

	public UISprite sTenGameTips;

	public UILabel lTenGameTips;

	public UILabel lResetTimeTips;

	public UILabel lTenGameValue;

	public UISprite sTenGameValueProgress;

	public UISprite sTenGameChest;

	public GameObject oCoolTime;

	public GameObject oTenValue;

	public UILabel lCoolTime;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tCoolTimeRegulator;

	public FlexibleRealTimeRegulator m_tRefreshRegulator;

	public UI_AnimationCtrl uiChestAnimationCtrl;

	public UI_LittleTips uiLittletip;

	private int minQuestPoint;

	private ConWin10Chest tenGameChestData;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdataState()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	private void UpdateRefreshTimeLeft()
	{
	}

	public void Hide()
	{
	}

	public bool CheckTenGame()
	{
		return false;
	}

	public void ShowNewTips(NewTipsType newTipsType, bool isShow, int num = 1)
	{
	}

	public void ShowNewTenGame(bool isShow, int num = 1)
	{
	}

	public bool GetConWinChestResponse()
	{
		return false;
	}
}
