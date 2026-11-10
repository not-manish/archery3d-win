using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Quest : MonoInstance<UI_Quest>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_Quest_TotalPoint uiQuestTotalPoint;

	public UI_Quest_DailyGifts uiQuestDailyGifts;

	public List<UI_Quest_DailyItem> DailyQuestLists;

	public List<GameObject> DailyQuestItems;

	public UI_Quest_DailyItem DailyQuestItem_New;

	public UI_AnimationCtrl uiNewItem_AnimationCtrl;

	public TweenPosition NewItemPosition;

	public UI_Quest_DailyNextItem uiQuestDailyNextItem;

	public UI_Quest_DailyItem_RefreshTips uiQuestDailyItemRefreshTips;

	public List<QuestDailyItemData> QuestItems;

	public QuestData questData;

	private long QuestStartTime;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public UIPanel uiScrollView;

	public UI_WaitLoading uiWaitLoading;

	public UIButton btBack;

	private bool hasSetScale;

	private bool buttonEnable;

	public bool isChangeQuestItem;

	private List<float> ItemY;

	private float t;

	public RewardType GetRewardType;

	private int refreshIndex;

	public List<Vector3> MoveStartPosition;

	public List<UI_Quest_DailyItem> uiQuestDailyItem;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void isRefreshQuest()
	{
	}

	public void ResetPosition()
	{
	}

	public void FirstUpdateItems()
	{
	}

	public void UpdateState(bool isChange = false)
	{
	}

	public void UpQuestItem()
	{
	}

	public void RestPosition()
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

	private void Update()
	{
	}

	public void ItemUPAnim()
	{
	}

	public void GetOldItemY()
	{
	}

	public bool GetRespones()
	{
		return false;
	}

	public void ShowRefreshAnimFinish()
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}

	public int GetOpenCount(CCChestReward chestReward)
	{
		return 0;
	}

	public bool IsShowing()
	{
		return false;
	}

	private void UpdateTimeLeft()
	{
	}

	public void QuestDailyItemRefreshTipsShow(object param)
	{
	}
}
