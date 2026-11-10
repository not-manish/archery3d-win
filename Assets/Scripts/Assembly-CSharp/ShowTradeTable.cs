using System.Collections.Generic;

public class ShowTradeTable
{
	public long time_mil;

	public int trade_event;

	public int ItemBgHeight;

	public List<ShowTradeItem> sub_items;

	public ShowTradeTable(long _time_mil, int _trade_event, int _itemBgHeight, List<ShowTradeItem> _sub_items = null)
	{
	}
}
