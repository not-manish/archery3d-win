public class OfflineHints
{
	public enum OfflineBuy
	{
		SINGLE_BUY_ERROR_LEVEL_ID = 0,
		SINGLE_BUY_ERROR_BUY_TIMES = 1,
		SINGLE_BUY_ERROR_NOT_ENGOUGH_GEM = 2,
		SINGLE_BUY_ERROR_NO_REASON = 10
	}

	public enum OfflineReward
	{
		SINGLE_REWARD_ERROR_LEVEL_ID = 0,
		SINGLE_REWARD_ERROR_HAS_REWARDED = 1,
		SINGLE_REWARD_ERROR_NOT_HAS_REWARD = 2,
		SINGLE_REWARD_ERROR_NOT_FINISHED = 3,
		SINGLE_REWARD_ERROR_NO_REASON = 10
	}

	public static string GetBuyTips(int reasonID)
	{
		return null;
	}

	public static string GetRewardTips(int reasonID)
	{
		return null;
	}
}
