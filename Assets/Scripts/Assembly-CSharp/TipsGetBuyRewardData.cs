using System;
using System.Collections.Generic;
using com.simple.proto;

public class TipsGetBuyRewardData
{
	public bool IsSuccess;

	public int ShopBuyType;

	public int ShopBuyIndex;

	public int ShopBuyId;

	public CCChestReward ChestReward;

	public bool IsShopBuy;

	public ChestKind chestKind;

	public Action HidePlayAction;

	public List<CCChestReward> ListChestReward;

	public TipsGetBuyRewardData(bool _IsSuccess, int _shopBuyType, int _ShopBuyIndex, int _ShopBuyId, bool _IsShopBuy = true, CCChestReward _ChestReward = null, ChestKind _chestKind = ChestKind.chest_challenge, List<CCChestReward> _listChestReward = null, Action hidePlayAction = null)
	{
	}
}
