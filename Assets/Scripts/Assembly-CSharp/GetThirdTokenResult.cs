public class GetThirdTokenResult
{
	public enum ResponseType
	{
		GEN_THIRD_TOKEN_ok = 0,
		GEN_THIRD_TOKEN_err_third_account_linked_to_another = 1,
		GEN_THIRD_TOKEN_err_third_account_invalid_type = 2,
		GEN_THIRD_TOKEN_err_db = 3,
		GEN_THIRD_TOKEN_err_invalid = 5,
		GEN_THIRD_TOKEN_err_third_account_has_not_linked = 6,
		GEN_THIRD_TOKEN_err_third_account_linked_cur_account = 7
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
