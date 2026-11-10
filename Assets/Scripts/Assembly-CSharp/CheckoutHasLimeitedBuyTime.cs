using System.Collections.Generic;

public class CheckoutHasLimeitedBuyTime
{
	public bool isHasUnShowLimeitedBuyTime;

	public LimitedTimeBuyCtrl.PackageType packageType;

	public Dictionary<LimitedTimeBuyCtrl.PackageType, LimitedTimeBuyItem> limitedTimeBuyItem;

	public List<int> UnShowPackageIDs;

	public CheckoutHasLimeitedBuyTime(bool _isHasUnShowLimeitedBuyTime, LimitedTimeBuyCtrl.PackageType _packageType, Dictionary<LimitedTimeBuyCtrl.PackageType, LimitedTimeBuyItem> _limitedTimeBuyItem)
	{
	}

	public CheckoutHasLimeitedBuyTime(bool _isHasUnShowLimeitedBuyTime, LimitedTimeBuyCtrl.PackageType _packageType, List<int> _unShowPackageIDs, Dictionary<LimitedTimeBuyCtrl.PackageType, LimitedTimeBuyItem> _limitedTimeBuyItem)
	{
	}
}
