public class LTBBuyHints
{
	public enum HintsType
	{
		LTB_ERR_UNKNOWN = 0,
		LTB_ERR_HANDLE_TYPE = 1,
		LTB_ERR_PACKAGE_TYPE = 2,
		LTB_ERR_IS_INCOOLDOWN = 3,
		LTB_ERR_IS_INUNLOCKED = 4,
		LTB_ERR_HAS_JOIN_ARENA = 5,
		LTB_ERR_HAS_ARENA_HIGH_TICKETS = 6,
		LTB_ERR_STATE_TYPE = 7,
		LTB_ERR_PRICE_TYPE = 8,
		LTB_ERR_GEM_NOT_ENOUGH = 9,
		LTB_ERR_PACK_ID_NOT_EXIST = 10
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
