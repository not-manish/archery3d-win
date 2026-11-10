using UnityEngine;
using com.simple.proto;

public class UI_Quest_DailyItem : MonoBehaviour
{
	public UIButton btCollect;

	public UIButton btRefresh;

	public UILabel lTitle;

	public UILabel lTitleBG;

	public UILabel lDescribe;

	public UILabel lQuestPointNum;

	public UILabel lQuestProgress;

	public UISprite sQuestProgress;

	public int NowPoint;

	public int MaxPoint;

	public UISprite sPoinyIcon;

	public GameObject oCollectIcon;

	public GameObject oRewardIcon;

	public GameObject oDown;

	public UILabel lRewardNum;

	public UISprite sRewardIcon;

	public UISprite sChestReward;

	public int QuestItemId;

	public int ItemIndex;

	public int chest_kind;

	public int chest_id;

	public RewardType rewardType;

	public QuestItem dailyQuestItem;

	public UI_AnimationCtrl uiRefreshAnimationCtrl;

	public UI_AnimationCtrl uiCollectAnimationCtrl;

	public TweenPosition collectTweenPosition;

	public TweenPosition refreshTweenPosition;

	private bool hasSetScale;

	private UI_Quest uiQuest;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param, int index, UI_Quest _uiQuest)
	{
	}

	public void UpdateInfo(QuestItem dailyQuestItem)
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

	public void SetRefreshButtonsState(bool state)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetSuccess(CCChestReward ccchestReward)
	{
	}

	public void HideChestOpen()
	{
	}

	public void ResetCollectTweenPosition()
	{
	}

	public void RefrshAnimShow()
	{
	}

	public void ReSetAnimValue()
	{
	}

	public void CollectAnimFinish()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
