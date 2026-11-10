using UnityEngine;

public class UI_MainMenu : MonoInstance<UI_MainMenu>, UIBase
{
	public UIButton btPlay;

	public UI_MainMenu_PlayerInfo uiPlayerinfo;

	public UI_MainMenu_ChestList uiChestList;

	public UI_MainMenu_MissonAndMiniGames uiMissonAndMiniGames;

	public UI_MainMenu_Onsale uiMainMenuOnsale;

	public UI_MainMenu_Video uiMainMenuVideo;

	public UI_MainMenu_Wifi uiMainMenu_Wifi;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_Finger_Click uiFingerClick;

	private bool HasShowOnsale;

	private bool hasSetScale;

	private UIMainMenuParam uiMainMenuParam;

	public UIPanel uiPanel;

	public GameObject oOfflinePanel;

	public GameObject oChestOnePanel;

	public Transform tFingerPos;

	private bool buttonEnable;

	private bool hasShowRankPrompt;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void SetUIOfflinePanel()
	{
	}

	private void SetTutorialPanel()
	{
	}

	public void ShowChest()
	{
	}

	private void HideTutorial()
	{
	}

	public void ShowHand()
	{
	}

	public void UpdateTutorial()
	{
	}

	public void PlayerInim()
	{
	}

	public void ShowAnimFinish()
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

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void CheckPopupWindow(bool isChestEquip = false)
	{
	}

	public bool CheckTutorial()
	{
		return false;
	}

	public bool isCheckEquip()
	{
		return false;
	}

	public bool CheckLeagueSegment()
	{
		return false;
	}

	public bool CheckChallengeReward()
	{
		return false;
	}

	public bool CheckIsShowRate()
	{
		return false;
	}

	public bool CheckLimitedTimeBuy()
	{
		return false;
	}

	public bool isShowLimitTimeBuyBtn()
	{
		return false;
	}

	public void SetDailyNewTips()
	{
	}

	public void CheckDownLoadAsset()
	{
	}

	public void Check_IsNeedDownload_Equip()
	{
	}

	public void CheckDailyBonus()
	{
	}

	public void CheckLingkAccount()
	{
	}

	public void CheckAchievement()
	{
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}

	public void ChestBuyTimeResponse()
	{
	}

	public bool CheckLeagueRankResponseShow()
	{
		return false;
	}

	public void ResPonse()
	{
	}
}
