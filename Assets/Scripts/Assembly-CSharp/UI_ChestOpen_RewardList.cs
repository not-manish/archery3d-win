using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_ChestOpen_RewardList : MonoBehaviour
{
	public UIButton btnContinue;

	public UILabel lFound;

	public Transform tItemList;

	public UI_ChestOpen_TopRewardItem TopRewardItem;

	public UI_ChestOpen_RewardItem rewardItem;

	private List<UI_ChestOpen_RewardItem> AllRewardItem;

	private List<UI_AnimationCtrl> AllRewardItemAnim;

	public UI_AnimationCtrl BtnAnimationCtrl;

	public UIScrollView ListContent;

	private FlexibleRealTimeRegulator m_TimeRegulator;

	private FlexibleRealTimeRegulator m_TimeTotalRegulator;

	private CCChestReward chestReward;

	public bool isShowMystery;

	private ChestVideoType chestVideoType;

	private float itemHalfWidth;

	private float StartHight;

	private float addWidth;

	private float addHigh;

	private bool buttonEnable;

	private int showCount;

	private void Start()
	{
	}

	public void Show(object param, bool _isShowMystery = false)
	{
	}

	public void ShowTopItem()
	{
	}

	public void UpdateInfo()
	{
	}

	public int GetOpenCount()
	{
		return 0;
	}

	public bool isEquipDouble(ChestOpenRewardItemData ChestRewardItemData, List<UI_ChestOpen_RewardItem> allRewardItem, int index)
	{
		return false;
	}

	public void ShowAllItems(List<UI_ChestOpen_RewardItem> allRewardItem)
	{
	}

	public void SetPosition(List<UI_ChestOpen_RewardItem> allRewardItem)
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

	public void GetSuccess(ChestOpenRewardItemData chestOpenRewardItemData)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	private void Update()
	{
	}
}
