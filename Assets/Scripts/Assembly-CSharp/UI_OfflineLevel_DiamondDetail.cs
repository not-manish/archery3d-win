using UnityEngine;

public class UI_OfflineLevel_DiamondDetail : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBuy;

	public UIButton btExit;

	public UILabel lGetNum;

	public UISprite sGetType;

	public GameObject oBuyDiamond;

	public GameObject oBuyDollar;

	public UILabel lBuyDiamondWhite;

	public UILabel lBuyDiamondRed;

	public UILabel lBuyDollar;

	private bool hasSetScale;

	private UIShopMoneyDetailParam uiParam;

	private UI_Shop uiShop;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState()
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
