using System;
using UnityEngine;

public class UI_DailyBonus_GetRewardTips : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btCollect;

	public UIButton btClose;

	public UISprite sArrowBg;

	public UISprite sRewardItem;

	public UILabel lRewardName;

	public UILabel lRewardCount;

	private bool hasSetScale;

	private DailyRewardData uiParam;

	private bool buttonEnable;

	private Action BtCloseAction;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowData()
	{
	}

	public string GetrewardName(RewardType rewardType)
	{
		return null;
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public void SetButtonCloseAction(Action action)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
