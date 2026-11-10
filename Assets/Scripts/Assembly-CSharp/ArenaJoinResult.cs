public class ArenaJoinResult
{
	public enum ResponseType
	{
		ARENA_JOIN_ERROR_NO_REASON = 0,
		ARENA_JOIN_ERROR_NOT_ENOUGH_GEM = 1,
		ARENA_JOIN_ERROR_HAS_JOINED = 2,
		ARENA_JOIN_ERROR_DB = 3,
		ARENA_JOIN_ERROR_GROUP = 4
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
