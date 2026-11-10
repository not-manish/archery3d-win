public class ChallengeJoinResult
{
	public enum ResponseType
	{
		CHALLENGE_JOIN_ERROR_NO_REASON = 0,
		CHALLENGE_JOIN_ERROR_NOT_ENOUGH_GOLD = 1,
		CHALLENGE_JOIN_ERROR_HAS_JOINED = 2,
		CHALLENGE_JOIN_ERROR_DB = 3,
		CHALLENGE_JOIN_ERROR_GROUP = 4
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
