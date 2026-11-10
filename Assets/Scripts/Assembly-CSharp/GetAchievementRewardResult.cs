public class GetAchievementRewardResult
{
	public enum ResponseType
	{
		ACHIEVEMENT_RESULT_OK = 0,
		ACHIEVEMENT_PID_NOT_EXIST = 1,
		ACHIEVEMENT_UID_ERR = 2,
		ACHIEVEMENT_NOT_HAVE_REWARD = 3,
		ACHIEVEMENT_DB_ERR = 4,
		ACHIEVEMENT_POINT_NOT_ENOUGH = 5,
		ACHIEVEMENT_HANDLE_INVALID = 6
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
