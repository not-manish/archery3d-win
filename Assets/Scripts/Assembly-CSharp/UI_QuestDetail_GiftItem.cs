using UnityEngine;
using com.simple.proto;

public class UI_QuestDetail_GiftItem : MonoBehaviour
{
	public UISprite sQuestItem;

	public UIButton btCollect;

	public UILabel lQuestPointNum;

	public GameObject oCollect;

	public GameObject oDown;

	public UILabel lRewardNum;

	public UISprite sRewardIcon;

	public UISprite sChestReward;

	public GameObject oHaveGift;

	public UISprite sWaitfresh;

	public UILabel lTime;

	public UISprite sQuestPoint;

	public int chest_kind;

	public int chest_id;

	public RewardType rewardType;

	public GiftItemInfo giftItemInfo;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private bool hasSetScale;

	private bool buttonEnable;

	private long overTime;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateInfo()
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

	public void GetSuccess(CCChestReward ccchestReward)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}
}
