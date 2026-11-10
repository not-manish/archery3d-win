using UnityEngine;

public class UI_ArenaStart : MonoInstance<UI_ArenaStart>, UIBase
{
	public GameObject oClassicTitle;

	public GameObject oGrandTitle;

	public GameObject[] oLose;

	public Transform tCurReward;

	public UILabel tCurGold;

	public UILabel tCurCard;

	public GameObject oNextReward;

	public UILabel tNextGold;

	public UILabel tNextCard;

	public GameObject[] oProgress;

	public UILabel lProgress;

	public UIButton btGiveup;

	public UIButton btStart;

	private int EntryFee;

	public UILabel lEntryFee;

	public UIButton btExit;

	public UIButton btChestReward;

	public UISprite sChestReward;

	public UISprite sWinBack;

	public GameObject oWinTen;

	public UISprite sWinTen_ten;

	public UISprite sWinTen_one;

	public GameObject oWinOne;

	public UISprite sWinOne_one;

	public UI_ArenaLevel_GiveUpTip uiArenaLevelGiveUpTip;

	public UI_Downloading_Tips uiDownloadingTips;

	private string SceneName;

	private SingleFileState isNeedDown;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public UI_AnimationCtrl uiChestAnimationCtrl;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	public void CheckIsDownloading(int levelId)
	{
	}

	public void ShowUnlock(SingleFileState singleFileState)
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

	public void OpenArenaChest()
	{
	}

	public bool GiveUpResponse()
	{
		return false;
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}

	public void GoToShopBuyGold()
	{
	}

	private void Update()
	{
	}
}
