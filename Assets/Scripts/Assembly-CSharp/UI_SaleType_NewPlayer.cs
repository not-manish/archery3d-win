using System.Collections.Generic;
using UnityEngine;

public class UI_SaleType_NewPlayer : UI_OnSale_Common_Item
{
	public List<LimitParticleParent> AllLimitParticleParent;

	public Transform tSaleItemParent;

	public UILabel lDiscountPriceBg;

	public UILabel lDiscountDollarBg;

	public UISprite sbg;

	public UISprite sEquipIcon;

	public UISprite sEquipName;

	public UILabel lFreeDescribe;

	public UILabel lFreeDescribeBg;

	public UILabel sFreeValueBg;

	public UILabel lOnceBuyTips;

	public UILabel lTime;

	public UILabel lOfferName;

	public UILabel lOfferNameBg;

	public bool isCool;

	public List<UI_Sale_Special_Item> childTwoCount;

	public List<UI_Sale_Special_Item> childOneCount;

	public override void UpdateInfo(bool isShop = false)
	{
	}

	private void Update()
	{
	}

	public bool SetNewDownSprite()
	{
		return false;
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

	public int GetRewardCount()
	{
		return 0;
	}

	public LimitParticleParent SetLimitParticleParent(int index)
	{
		return null;
	}
}
