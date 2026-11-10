public class RestoreThirdAccountResult
{
	public enum ResponseType
	{
		RESTORE_THIRD_RES_ok = 0,
		RESTORE_THIRD_RES_err_third_account_not_linked = 1,
		RESTORE_THIRD_RES_err_third_account_token_invalid = 2,
		RESTORE_THIRD_RES_err_invalid = 3,
		RESTORE_THIRD_RES_err_db = 4,
		RESTORE_THIRD_RES_err_third_account_type = 5
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
