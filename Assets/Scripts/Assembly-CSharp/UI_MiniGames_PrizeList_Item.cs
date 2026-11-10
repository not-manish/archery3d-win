using UnityEngine;

public class UI_MiniGames_PrizeList_Item : MonoBehaviour
{
	public UIButton btnShowInfo;

	public UISprite sItembg;

	public UISprite sReward;

	public UISprite sRewardbg;

	public UISprite sRewardSpecialbg;

	public UILabel lRewardCount;

	public UILabel lRewardCountbg;

	public UILabel lRewardValue;

	public UILabel lRewardValuebg;

	public RouletteGiftsOriData oridata;

	private GamblingRouletteCtrl.RouletteType RouletteType;

	private int chest_id;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void ShowReward(RouletteGiftsOriData _oridata, GamblingRouletteCtrl.RouletteType rouletteType)
	{
	}

	public void ChangeSpecialRewardIcon(bool isSpecial)
	{
	}

	public void ShowReward(RewardType rewardsNum)
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
