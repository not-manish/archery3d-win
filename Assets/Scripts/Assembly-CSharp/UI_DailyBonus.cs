using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_DailyBonus : MonoInstance<UI_DailyBonus>, UIBase
{
	public UI_DailyBonus_Daily uiDailyBonusDaily;

	public UI_DailyBonus_FreeGift uiDailyBonusFreeGift;

	public UI_DailyBonus_GetRewardTips uiDailyBonusGetRewardTips;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBack;

	public UIButton btnDailyBonus;

	public UIButton btnFreeGift;

	public UILabel lDailyBonusShow;

	public UILabel lDailyBonusHide;

	public UILabel lFreeGiftShow;

	public UILabel lFreeGiftHide;

	public GameObject oDailyBonusNewTips;

	public UILabel lDailyBonusNewTips;

	public GameObject oFreeGiftPanelNewTips;

	public UILabel lFreeGiftPanelNewTips;

	public GameObject oDailyBonusPanel;

	public GameObject oFreeGiftPanel;

	private int CanCollectIndex;

	private DailyAndFreeGiftData dailyAndFreeGiftData;

	private ShowDailyOrFreeGift showDailyOrFreeGift;

	private bool hasSetScale;

	private bool buttonEnable;

	[HideInInspector]
	public UI_DailyBonus_DayItem GetDailyBonus_DayItem;

	private CCSevenDailyBonusResponse res;

	[HideInInspector]
	public DailyGiftsData dailyGiftsData;

	private CCVideoNewResponse VideoNewResponse;

	public List<Vector3> MoveStartPosition;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void SelectShowPanel(ShowDailyOrFreeGift _showDailyOrFreeGift)
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

	public void ShowNewTips()
	{
	}

	public void DailyUpdateShow(ShowDailyOrFreeGift _showDailyOrFreeGift)
	{
	}

	public void ShowRewardTips(DailyRewardData dailyRewardData)
	{
	}

	private bool GetRespone()
	{
		return false;
	}

	public void IsWatchVideo()
	{
	}

	public void clearData()
	{
	}

	private bool GetVideoNewResponse()
	{
		return false;
	}

	public void IsGiftWatchVideo()
	{
	}

	public void clearGiftData()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}

	public int GetOpenCount(CCChestReward chestReward)
	{
		return 0;
	}
}
