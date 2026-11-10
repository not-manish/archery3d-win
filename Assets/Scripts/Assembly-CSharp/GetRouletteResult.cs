public class GetRouletteResult
{
	public enum ResponseType
	{
		ROULETTE_RESULT_ERR_TYPE = 0,
		ROULETTE_RESULT_ERR_TIME_NOT_REACH = 1,
		ROULETTE_RESULT_ERR_TIMES_NOT_ENOUGH = 2,
		ROULETTE_RESULT_ERR_NO_REASON = 3,
		ROULETTE_RESULT_ERR_GEN_NOT_ENOUGH = 4
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
