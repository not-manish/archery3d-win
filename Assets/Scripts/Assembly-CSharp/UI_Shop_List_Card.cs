using System.Collections.Generic;
using UnityEngine;

public class UI_Shop_List_Card : MonoBehaviour
{
	public UIWidget widgetAll;

	public UI_Shop_List_Card_Item[] uiCardList;

	public UI_Shop_List_Card_Item_DailyFree[] uiDailyFreeList;

	private UI_Shop_List uiShopList;

	private bool isGetDataFromServer;

	private float Distancex;

	private float startY;

	private float DistanceY;

	public void Show(bool _isGetDataFromServer, UI_Shop_List _uiShopList)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void UpdateState(bool _isGetDataFromServer)
	{
	}

	public ShopCardType getCardType(int Garde, bool isUnlock, ShopCardFreeOriData OriData, bool isRefresh)
	{
		return ShopCardType.Free;
	}

	public void SetLocalPosition(List<Transform> Items)
	{
	}

	public void SetLocalPosition(float yPosition)
	{
	}
}
