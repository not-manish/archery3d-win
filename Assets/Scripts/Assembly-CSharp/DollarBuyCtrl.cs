using UnityEngine;

public class DollarBuyCtrl : MonoBehaviour
{
	public const string BuyResponsIsOK = "Purchase success!";

	public const string BuyResponsIsFailed = "Purchase failed!";

	public static int BUY_GEM_REASON;

	public const int BUY_GEM_REASON_unknown = 0;

	public const int BUY_GEM_REASON_buy_card = 1;

	public const int BUY_GEM_REASON_buy_gold = 2;

	public const int BUY_GEM_REASON_open_chest = 3;

	public const int BUY_GEM_REASON_join_arena = 4;

	public const int BUY_GEM_REASON_buy_arrow = 5;

	public const int BUY_GEM_REASON_buy_LTB = 6;

	public const int BUY_GEM_REASON_buy_chest = 7;

	public const int BUY_GEM_REASON_buy_offline_power = 8;

	public const int BUY_GEM_REASON_buy_gem_roulette = 9;
}
