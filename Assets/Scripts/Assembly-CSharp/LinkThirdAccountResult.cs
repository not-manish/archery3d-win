public class LinkThirdAccountResult
{
	public enum ResponseType
	{
		LINK_THIRD_RES_ok = 0,
		LINK_THIRD_RES_err_third_account_type = 1,
		LINK_THIRD_RES_err_third_account_linked_to_another = 2,
		LINK_THIRD_RES_err_third_account_token_invalid = 3,
		LINK_THIRD_RES_err_cur_account_has_linked = 4,
		LINK_THIRD_RES_err_invalid = 5,
		LINK_THIRD_RES_err_db = 6
	}

	public static string GetTips(ResponseType type)
	{
		return null;
	}
}
