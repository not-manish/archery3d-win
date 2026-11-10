using System.Collections.Generic;
using UnityEngine;

public class UI_GetAchievement_Tips : MonoInstance<UI_GetAchievement_Tips>, UIBase
{
	private enum TipsState
	{
		Null = 0,
		PlayMove = 1,
		PlayingAnim = 2,
		PlayAnimEnd = 3
	}

	public static Dictionary<AchievementListOriData, bool> AllAchievementItems;

	public static Dictionary<int, QuestItemData> AllNewQuestItems;

	public UI_GetQuest_Item uiGetQuestItemOne;

	public UI_GetAchievement_Item uiGetAchievementItemOne;

	public Transform AchievementItemParent;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool isSpecialUIShowAnim;

	private GetRewardTips currGetRewardTips;

	private TipsState currTipsState;

	private bool buttonEnable;

	public void Show(object param)
	{
	}

	private void Update()
	{
	}

	private void UpState()
	{
	}

	private void setChangeState(TipsState _tipsState)
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

	public void Hide(object param)
	{
	}

	public void SetAllAchievementItemsValue(AchievementListOriData achievementListOriData, bool isShow)
	{
	}

	public void SetAllNewQuestItemsValue(int quest_id, QuestItemData questItem)
	{
	}

	public void SetUIShowAnim(bool isShow)
	{
	}

	public bool isShowAnim()
	{
		return false;
	}

	public void ClearData()
	{
	}
}
