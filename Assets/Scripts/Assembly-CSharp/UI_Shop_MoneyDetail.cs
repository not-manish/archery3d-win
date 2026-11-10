using UnityEngine;

public class UI_Shop_MoneyDetail : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBuy;

	public UIButton btnInfo;

	public UIButton btExit;

	public UILabel lBuyItemName;

	public UILabel lBuyItemNameBg;

	public UISprite sBuyItemQuality;

	public UILabel lGetNum;

	public UISprite sGetType;

	public UISprite sPriceType;

	public GameObject oFree;

	public GameObject oBuyDiamond;

	public GameObject oBuyDollar;

	public UILabel lBuyDiamondWhite;

	public UILabel lBuyDiamondRed;

	public UILabel lBuyDollar;

	private ShopCardFreeOriData oridata;

	private ShopListCardItemDailyFreeData FreeData;

	private bool hasSetScale;

	private UIShopMoneyDetailParam uiParam;

	private UI_Shop uiShop;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Shop _uiShop, object param)
	{
	}

	private void UpdateState()
	{
	}

	public void setCardQuality(CardQuality cardQuality = CardQuality.Blue)
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

	private bool IsGemIsEnough()
	{
		return false;
	}

	public void BuyPriceNotEnoughTips(TipTitleType tipTitleType)
	{
	}

	public void GoToShopBuyGem()
	{
	}

	public void GoToShopBuyGold()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
