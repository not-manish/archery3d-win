using System.Collections.Generic;
using UnityEngine;

public class UI_DailyBonus_Daily : MonoBehaviour
{
	public List<UI_DailyBonus_DayItem> uiDailyBonusDayItems;

	public UIButton btnCollect;

	public UILabel lNormalCollect;

	public UILabel lCollectTime;

	public UILabel lTime;

	private UI_DailyBonus uiDailyBonus;

	private int CanCollectIndex;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private SevenDailyBonus sevenDailyBonus;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_DailyBonus _uiDailyBonus)
	{
	}

	public void UpdateDailyState()
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

	private void UpdateTimeLeft()
	{
	}

	private void Update()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
