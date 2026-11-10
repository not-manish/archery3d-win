using UnityEngine;

public class UI_OnSale_Common_Item : MonoBehaviour
{
	public UIButton btBuy;

	public UILabel lOriginalPrice;

	public UILabel lDiscountPrice;

	public UILabel lOriginalDollar;

	public UILabel lDiscountDollar;

	public UISprite sDiscountPayType;

	public UISprite sOriginalPayType;

	public UILabel lTopsName;

	public UILabel lTopsNamebg;

	public UILabel sFreeValue;

	public LimitedTimeBuyOriData limitedTimeBuyOriData;

	public SaleTypeItem saleTypeItem;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private PlayerData playerdata;

	private bool hasSetScale;

	private bool isShop;

	private bool buttonEnable;

	private void Start()
	{
	}

	public virtual void Show(object Param, bool _isShop = false)
	{
	}

	public virtual void UpdateInfo(bool isShop = false)
	{
	}

	public virtual void Hide(object param)
	{
	}

	public virtual void EnableButtons()
	{
	}

	public virtual void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GoToShopBuyGem()
	{
	}

	public virtual bool IsShowing()
	{
		return false;
	}
}
