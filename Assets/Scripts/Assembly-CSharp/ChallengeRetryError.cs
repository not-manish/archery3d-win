public class ChallengeRetryError
{
	public enum ResponseType
	{
		RETRY_FAIL_ROOM_NOT_EXIST = 0,
		RETRY_FAIL_GOLD_NOT_ENOUGH = 1,
		RETRY_FAIL_OTHERS = 2
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
