using System.Collections.Generic;
using com.simple.proto;

public class LimitedTimeBuyData
{
	public LimitedTimeBuyItem new_player_pack;

	public LimitedTimeBuyItem level_unloc_pack;

	public LimitedTimeBuyItem arena_pack;

	public LimitedTimeBuyItem challenge_pack;

	public LimitedTimeBuyItem continue_loses_pack;

	public LimitedTimeBuyItem equip_pack;

	public LimitedTimeBuyItem equip2_pack;

	public void Update(CCLimitedTimeBuy data)
	{
	}

	public CheckoutHasLimeitedBuyTime GetUnShowLimitedTimeBuyItem()
	{
		return null;
	}

	public CheckoutHasLimeitedBuyTime GetShowAgainLimitedTimeBuyItem(LimitedTimeBuyCtrl.PackageType packageType)
	{
		return null;
	}

	public List<SaleTypeItem> GetLimitedTimeBuyItem()
	{
		return null;
	}

	public SaleTypeItem GetLimitedTimeBuyItem(int pack_unloc_ids)
	{
		return null;
	}

	public void SetHasShown()
	{
	}
}
