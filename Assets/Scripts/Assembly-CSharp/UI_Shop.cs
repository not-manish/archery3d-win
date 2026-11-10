using UnityEngine;

public class UI_Shop : MonoInstance<UI_Shop>, UIBase
{
	public UI_Shop_List uiShopList;

	public UI_Shop_MoneyDetail uiMoneyDetail;

	private bool hasSetScale;

	public UIShopParam uiParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
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

	public void ScrollToGem()
	{
	}

	public void ScrollToGold()
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
