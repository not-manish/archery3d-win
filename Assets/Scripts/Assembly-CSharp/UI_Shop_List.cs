using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Shop_List : MonoBehaviour
{
	public UI_Shop_List_Card uiCardList;

	public UI_Shop_List_Others uiLimitedTimeBuyList;

	public UI_Shop_List_Chest uiChestList;

	public List<UI_Shop_List_Others> uiOtherList;

	public UIWidget widgetStart;

	public UIWidget widgetEnd;

	private float StartY;

	public UIScrollViewMy uiScrollView;

	public UIPanel uiScrollPanel;

	public UILabel lTimeLeft;

	[HideInInspector]
	public UI_Shop uiShop;

	private EquipType focusEquip;

	private bool buttonEnable;

	public bool isUpToShow;

	private FlexibleRealTimeRegulator m_tUpdateTimeRegulator;

	private float TargetPositionY;

	private void Start()
	{
	}

	public void Show(UI_Shop _uiShop)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateLTB()
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

	private void SetPositon(bool enfore)
	{
	}

	private void Update()
	{
	}

	private void UpdateShopTime()
	{
	}

	public void SetDrapPanelPosition()
	{
	}

	public void GetMoveToTarget(bool isMoveTo, ShopBuyType firstShowType)
	{
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}

	public void UpdateShopResponse()
	{
	}

	public bool BuyShopResponse()
	{
		return false;
	}

	public int TipRewardType(int reward_type)
	{
		return 0;
	}

	public bool LimitedTimeBuyResponse()
	{
		return false;
	}

	private void PurchaseLTBFinished(int PackageId, CCChestReward ChestRewardAll)
	{
	}

	private void PurchaseLTBGetReward()
	{
	}

	private void PurchaseLTBGoldGetReward()
	{
	}
}
