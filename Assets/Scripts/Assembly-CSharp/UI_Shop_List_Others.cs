using System.Collections.Generic;
using UnityEngine;

public class UI_Shop_List_Others : MonoBehaviour
{
	private List<UI_Shop_List_Others_Item> uiOthersItem;

	public ShopBuyType shopBuyType;

	public UIWidget widgetAll;

	private int ItemHeight;

	private float ItemStartLocalX;

	public float ItemWidth;

	public Transform tItemParent;

	private UI_Shop_List uiShopList;

	public List<UI_OnSale_Common_Item> allLimitedItem;

	public Transform LTBParent;

	public void Show(UI_Shop_List _uiShopList)
	{
	}

	public void UpdateState()
	{
	}

	public void Hide()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	private void CreateItems(List<int> ItemIDs)
	{
	}

	private void CreateLimitedItems(List<SaleTypeItem> Items)
	{
	}

	public void SetLocalPosition(float yPosition)
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
