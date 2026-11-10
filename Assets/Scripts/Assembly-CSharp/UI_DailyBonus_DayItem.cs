using UnityEngine;

public class UI_DailyBonus_DayItem : MonoBehaviour
{
	public UIButton btnCollect;

	public UILabel lDailyRewardDayTitle;

	public UILabel lDailyRewardDayTitlebg;

	public UISprite sChestReward;

	public UISprite sCollectMark;

	public UILabel lDailyRewardCount;

	public UILabel lDailyRewardCountbg;

	public UISprite sSuperBonus;

	public UISprite sRewardIconBg;

	private Color32 cHadCollect;

	private Color32 cNotCollectNum;

	private Color cNotCollect;

	public UIScrollView sFlow;

	public DailyBonusDayItem dailyBonusDayItem;

	public int chest_id;

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

	public void ShowReward(RewardType rewardsNum)
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

	private void ButtonOnClicked(GameObject button)
	{
	}
}
