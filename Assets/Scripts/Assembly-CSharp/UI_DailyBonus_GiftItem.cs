using UnityEngine;

public class UI_DailyBonus_GiftItem : MonoBehaviour
{
	public UIButton btnCollect;

	public UILabel lNormalCollect;

	public UILabel lCollectTime;

	public UILabel lTime;

	public UIButton btnWatchVideo;

	public UILabel lVideoCollect;

	public UILabel lPreparing;

	public UILabel lWatchVideo;

	public UILabel lCollect;

	public UISprite sVideo;

	public UIButton btnItemInfo;

	public UISprite sChestReward;

	public UISprite sCollectMark;

	public UILabel lDailyRewardName;

	public UILabel lDailyRewardCount;

	public UISprite sVedioProgress;

	public UILabel lVedioProgressValue;

	public UISprite sVedioProgressFront;

	public UILabel lVedioProgressTips;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tVideoTimeRegulator;

	private DailyBonusGiftItemData dailyBonusGiftItemData;

	private bool isCanCollect;

	private DailyGiftsData dailyGiftsData;

	private VideoFreeNewData videoFreeNewData;

	private UI_DailyBonus_FreeGift uiDailyBonusFreeGift;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_DailyBonus_FreeGift _uiDailyBonusFreeGift, object param)
	{
	}

	public void isShowReward(bool isShow)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	private void Update()
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

	public void SendOrderResquest(bool isFinish)
	{
	}

	public void SendCountResquest(bool isFinish)
	{
	}
}
