public class LimitedTimeBuyCtrl
{
	public enum PackageState
	{
		None = 0,
		Unlocked = 1,
		Cooldown = 2,
		SellOut = 3
	}

	public enum PackageType
	{
		NewPlayer = 1,
		LevelUnlock = 2,
		Arena = 3,
		Challenge = 4,
		ContinueLose = 5,
		EquipPack = 6,
		Equip2Pack = 7
	}

	public enum HandleType
	{
		UnlockPackage = 0,
		HasShowPackage = 1,
		BuyPackage = 2,
		UpdataPackageState = 3
	}

	public enum PriceType
	{
		Dollar = 1,
		Gem = 2
	}
}
