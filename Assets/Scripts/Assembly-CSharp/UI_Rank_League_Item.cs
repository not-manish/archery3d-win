using UnityEngine;

public class UI_Rank_League_Item : MonoBehaviour
{
	public GameObject oNormalItems;

	public GameObject oPromotion;

	public GameObject oRelegation;

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

	private UIRankLeagueItemParam uiParam;

	public PlayerHeadShow playerHeadShow;

	private int rank;

	private bool buttonEnable;

	public void Show(UIRankLeagueItemParam _uiParam)
	{
	}

	private void UpdateState()
	{
	}

	public void UpdateState_Rank()
	{
	}

	public static int GetLeagueChestID(int segment, int rank)
	{
		return 0;
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
