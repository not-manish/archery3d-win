public class HandleAskFriendsError
{
	public enum ResponseType
	{
		ASK_FRIENDS_RESULT_OK = 0,
		ASK_FRIENDS_RESULT_FRIENDS_NOT_EXIST = 1,
		ASK_FRIENDS_RESULT_OTHERS = 2
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
