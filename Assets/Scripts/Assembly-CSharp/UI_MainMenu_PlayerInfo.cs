using UnityEngine;

public class UI_MainMenu_PlayerInfo : MonoBehaviour
{
	public UIButton btDaily;

	public UISprite sDailyNewTips;

	public UILabel lDailyNewTips;

	public UIButton btPlayerinfo;

	public UISprite sAchieveNewTips;

	public UILabel lAchieveNewTips;

	public UISprite sTrophy;

	public UILabel lPlayerName;

	public UILabel lPlayerNamebg;

	public UILabel lPlayerCup;

	public UILabel lPlayerCupbg;

	private PlayerData playerData;

	public PlayerHeadShow playerHeadShow;

	private void Start()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void UpdateState()
	{
	}

	public void SetPlayerName(string namestr)
	{
	}

	private void UpdateSelfAvatar()
	{
	}

	public void ShowNewTips(NewTipsType newTipsType, bool isShow, int num = 1)
	{
	}

	public void ShowNewDaily(bool isShow, int num = 1)
	{
	}

	public void ShowNewAchieve(bool isShow, int num = 1)
	{
	}

	public void GetDaily()
	{
	}

	public void GetFreeVideo()
	{
	}

	public void GetPlayerInfo()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
