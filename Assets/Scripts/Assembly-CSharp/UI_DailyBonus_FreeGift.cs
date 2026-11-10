using System.Collections.Generic;
using UnityEngine;

public class UI_DailyBonus_FreeGift : MonoBehaviour
{
	public List<UI_DailyBonus_GiftItem> uiDailyBonusDayItems;

	private bool hasSetScale;

	public UILabel lResetTime;

	public UILabel lResetTimeBg;

	public UI_WaitLoading uiWaitLoading;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private VideoFreeNewData videoFreeNewData;

	public void Show(UI_DailyBonus _uiDailyBonus)
	{
	}

	public void UpdateFreeGiftState()
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public void ShowWaitPanel(bool isShow)
	{
	}

	public void Hide(object param)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
