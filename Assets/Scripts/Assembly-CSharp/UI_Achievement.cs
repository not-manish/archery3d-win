using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Achievement : MonoInstance<UI_Achievement>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBack;

	public UI_Achievement_TotalPoint uiAchievementTotalPoint;

	public UI_AchieveClassify uiAchieveClassify;

	private bool hasSetScale;

	private bool buttonEnable;

	public List<Vector3> MoveStartPosition;

	public List<AchieveItem> uiAchievementItem;

	private void Start()
	{
	}

	public void Show(object param)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool GetSuccess()
	{
		return false;
	}

	public RewardType isChestGoldOrGem(CCChestReward chestReward)
	{
		return RewardType.Null;
	}

	public void GotoNextAchievement()
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}

	public int GetOpenCount(CCChestReward chestReward)
	{
		return 0;
	}
}
