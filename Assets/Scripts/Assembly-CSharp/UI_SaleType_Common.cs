using System.Collections.Generic;
using UnityEngine;

public class UI_SaleType_Common : UI_OnSale_Common_Item
{
	public UILabel lDiscountDollarbg;

	public UILabel lDiscountPricebg;

	public UILabel lTipsBuyTime;

	public UISprite sbg;

	public UISprite sTopSaletype;

	public Transform tSaleItemParent;

	[HideInInspector]
	public UI_Sale_Common_Item uiSaleCommonItem;

	public UILabel lTime;

	public bool isCool;

	private List<UI_Sale_Common_Item> childCount;

	public override void UpdateInfo(bool isShop = false)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public void LoadItem(bool isShop = false)
	{
	}

	public void getChildPositionX(int childCounts, float childwidth)
	{
	}
}
