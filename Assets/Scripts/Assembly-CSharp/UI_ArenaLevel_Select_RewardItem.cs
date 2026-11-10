using UnityEngine;

public class UI_ArenaLevel_Select_RewardItem : MonoBehaviour
{
	public UILabel lWinNum;

	public UISprite sChest;

	public UILabel[] lCards;

	public UIButton btnItem;

	public UISprite sMoney;

	public UILabel lMoney;

	private ArenaType arenaType;

	private int winNum;

	private UI_ArenaLevel_Select_RewardList uiList;

	private ChallengeChestOriData chestOriData;

	private void Start()
	{
	}

	public void UpdateState(UI_ArenaLevel_Select_RewardList _uiList, ArenaType _arenaType, int _winNum)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
