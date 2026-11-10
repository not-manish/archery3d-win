public class ResultCode
{
	public const int ok = 0;

	public const int err_invalid = 1;

	public const int err_db = 2;

	public const int err_not_own = 3;

	public const int err_can_not_upgrade = 4;

	public const int err_top_limit = 5;

	public const int err_not_enough = 6;

	public const int err_consumed = 7;

	public const int err_not_sell = 8;

	public const int err_not_unlock = 9;

	public const int err_rewarded = 10;

	public const int err_too_length = 11;

	public const int local_time_out = int.MaxValue;

	public const int err_third_account = 4001;

	public const int err_third_account_invalid_type = 4002;

	public const int err_third_account_linked_to_another = 4003;

	public const int err_third_account_token_invalid = 4004;

	public const int err_cur_account_has_linked = 4005;

	public const int err_third_account_not_linked = 4006;
}
