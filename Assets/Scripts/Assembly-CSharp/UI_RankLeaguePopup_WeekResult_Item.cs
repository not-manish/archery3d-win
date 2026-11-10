using UnityEngine;
using com.simple.proto;

public class UI_RankLeaguePopup_WeekResult_Item : MonoBehaviour
{
	public GameObject oChest;

	public UISprite sChestIconBack;

	public GameObject oLeagueChest;

	public UIButton btChest;

	public UIButton btItem;

	public UISprite sBacground;

	public UILabel lRank;

	public UILabel lRankbg;

	public UILabel lPlayerName;

	public UILabel lPlayerGold;

	public PlayerHeadShow playerHeadShow;

	private UI_RankLeaguePopup_WeekResult uiLeagueRank;

	private bool isMe;

	private CCRankItem rankItem;

	private int rank;

	private bool hasUpdate;

	private bool buttonEnable;

	public void UpdateState(UI_RankLeaguePopup_WeekResult _uiLeagueRank, int index, CCRankItem _rankItem, bool _isMe)
	{
	}

	private string GoldToStringK(long gold)
	{
		return null;
	}

	public void UpdatePhoto()
	{
	}

	private void Start()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
