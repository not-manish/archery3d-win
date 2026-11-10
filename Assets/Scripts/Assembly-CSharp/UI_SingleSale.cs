using UnityEngine;
using com.simple.proto;

public class UI_SingleSale : MonoInstance<UI_SingleSale>, UIBase
{
	public UIButton btnBack;

	public Transform SaleItemParent;

	private SaleTypeItem saleTypeItem;

	private OnSaleShowData onSaleShowData;

	private UI_SaleType_Common uiSaleTypeCommon;

	private UI_SaleType_Level uiSaleTypeLevel;

	private UI_SaleType_NewPlayer uiSaleTypeNewPlayer;

	public UI_AnimationCtrl uiAnimationCtrl;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateState()
	{
	}

	private void CreateLimitedItems(SaleTypeItem Item)
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

	public bool BuyShopResponse()
	{
		return false;
	}

	public bool LimitedTimeBuyResponse()
	{
		return false;
	}

	private void PurchaseFinished(int PackageId, CCChestReward ChestRewardAll)
	{
	}

	private void PurchaseLTBGetReward()
	{
	}

	private void PurchaseLTBGoldGetReward()
	{
	}
}
