public class SevenDailyBonusResult
{
	public enum ResponseType
	{
		SEVEN_DAILY_BONUS_RESULT_OK = 0,
		SEVEN_DAILY_BONUS_RESULT_ERR_DB = 1,
		SEVEN_DAILY_BONUS_RESULT_ERR_TIME_NOT_REACH = 2,
		SEVEN_DAILY_BONUS_RESULT_ERR_UNKNOWN = 3
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
