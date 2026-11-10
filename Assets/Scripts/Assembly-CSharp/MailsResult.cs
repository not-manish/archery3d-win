public class MailsResult
{
	public enum ResponseType
	{
		MAILS_RESULT_OK = 0,
		MAILS_UID_PID_NOT_EXIST = 1,
		MAILS_DB_ERR = 2,
		MAILS_HANDLE_INVALID = 3
	}

	public static string GetTips(int type)
	{
		return null;
	}
}
