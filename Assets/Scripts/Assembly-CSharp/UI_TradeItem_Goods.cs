using UnityEngine;

public class UI_TradeItem_Goods : MonoBehaviour
{
	public enum NameColor
	{
		White = 0,
		Green = 1,
		Blue = 2,
		Purple = 3,
		Yellow = 4,
		Orange = 5,
		red = 6,
		NavyBlue = 7,
		Gold = 8,
		Mauve = 9
	}

	public UILabel lName;

	public UILabel lCount;

	private TradeGoodsBigType tradeGoodsBigType;

	private TradeGoodsSmallType tradeGoodsSmallType;

	public UISprite sCostIcon;

	[HideInInspector]
	public ShowTradeItem showTradeItem;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private int ItemID;

	private bool hasSetScale;

	public void Show(object Param)
	{
	}

	public void UpdateInfo()
	{
	}

	private void UpdateState_Guide()
	{
	}

	private void UpdateState_Classic()
	{
	}

	private void UpdateState_League()
	{
	}

	private void UpdateState_Challenge()
	{
	}

	public void ShowReward()
	{
	}

	public void ShowSmallReward()
	{
	}

	public void SetChestNameColor(int chestKind)
	{
	}

	public void SetNameColor(NameColor nameColor)
	{
	}

	public Color HexToColor(string hex)
	{
		return default;
	}
}
