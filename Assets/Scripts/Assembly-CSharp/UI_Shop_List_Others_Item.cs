using UnityEngine;

public class UI_Shop_List_Others_Item : MonoBehaviour
{
	public UILabel lGrade;

	public UISprite sItem;

	public UILabel lNameOrNum;

	public GameObject oBuyEmpty;

	public GameObject oBuyDiamond;

	public GameObject oBuyDollar;

	public UILabel lBuyDollar;

	public UILabel lBuyDiamond;

	public UIButton btSelect;

	public GameObject oFree;

	public UILabel lFreeNumber;

	public UILabel lFreeNumberbg;

	private UI_Shop uiShop;

	private ShopBuyType buyType;

	private int shopID;

	public UIChangeWidgeColor uiChangeWidgeColor;

	private bool isGetDataFromServe;

	private bool hasSetScale;

	private bool buttonEnable;

	public void Show(UI_Shop _uiShop, ShopBuyType _buyType, int _ID)
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateState(bool _isGetDataFromServe, UI_Shop _uiShop, ShopBuyType _buyType, int _ID)
	{
	}

	private void Start()
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
