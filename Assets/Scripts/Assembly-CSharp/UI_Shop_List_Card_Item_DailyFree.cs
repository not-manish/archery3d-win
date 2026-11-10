using UnityEngine;

public class UI_Shop_List_Card_Item_DailyFree : MonoBehaviour
{
	public UILabel lGradeOrType;

	public UISprite sItem;

	public UISprite sItemBg;

	public UISprite sBuyPriceType;

	public UILabel lName;

	public GameObject oSaleCard;

	public GameObject oComming;

	public GameObject oUnlock;

	public UILabel lUnLock;

	public GameObject oSaleOut;

	public GameObject oFree;

	public GameObject oBuyDiamond;

	public UILabel lBuyDiamond;

	public UILabel lCount;

	public UIButton btSelect;

	private UI_Shop uiShop;

	private ShopListCardItemDailyFreeData shopListCardItemDailyFreeData;

	public UIChangeWidgeColor uiChangeWidgeColor;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Shop _uiShop, object Param)
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateState(ShopListCardItemDailyFreeData FreeData)
	{
	}

	public void setgradeColor(CardQuality cardQuality = CardQuality.Blue)
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
}
