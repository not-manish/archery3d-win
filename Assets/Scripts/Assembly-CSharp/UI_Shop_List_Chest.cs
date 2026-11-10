using UnityEngine;

public class UI_Shop_List_Chest : MonoBehaviour
{
	public UIWidget widgetAll;

	public UI_Shop_List_Others_Item[] uiChestList;

	private UI_Shop_List uiShopList;

	private bool isGetDataFromServer;

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

	public void SetLocalPosition(float yPosition)
	{
	}
}
