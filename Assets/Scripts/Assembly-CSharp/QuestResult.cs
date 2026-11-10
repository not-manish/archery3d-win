public class QuestResult
{
	public enum ResponseType
	{
		QUEST_RESULT_OK = 0,
		QUEST_DB_ERR = 1,
		QUEST_HANDLE_INVALID = 2,
		QUEST_INDEX_INVALID = 3,
		QUEST_HAS_REWARDED = 4,
		QUEST_CONDITION_UNSATISFIED = 5,
		QUEST_ERR_HAS_CHANGED = 6,
		QUEST_ERROR_OTHER_REASON = 10
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
