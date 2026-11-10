using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_TradeItem : MonoBehaviour
{
	public UILabel lDay;

	public UILabel lTime;

	public UILabel lEventName;

	private TradeEvent tradeEvent;

	private TradeGoodsBigType tradeGoodsBigType;

	private IList<CCTradeItem> AllTradeItems;

	public UISprite SItemBg;

	public UI_TradeItem_Goods goodsItem;

	private List<UI_TradeItem_Goods> AllgoodsItems;

	private List<TradeItemGoodsData> AllTradeItemGoodsData;

	public Transform objCost;

	public Transform objGet;

	public UISprite objGetIcon;

	public UISprite sline;

	public UISprite stitle;

	[HideInInspector]
	public ShowTradeTable showTradeTable;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private float CostStartY;

	private float GetStartY;

	private int objCostStartY;

	private float objGetStartY;

	private float objLineStartY;

	private int AddY;

	private int ShowLineDistance;

	private bool hasSetScale;

	public void Show(object Param)
	{
	}

	public void UpdateInfo()
	{
	}

	public bool isShowGetLeftObj(ShowTradeItem item)
	{
		return false;
	}

	public void AddItems()
	{
	}

	public void ShowGoodsItem(List<ShowTradeItem> showTradeTableItem, List<ShowTradeItem> removeItem)
	{
	}

	public void showGetIcon(ShowTradeItem removeItem0)
	{
	}

	private void UpdateState_Guide(ShowTradeItem removeItem0)
	{
	}

	private void UpdateState_Classic(ShowTradeItem removeItem0)
	{
	}

	private void UpdateState_League(ShowTradeItem removeItem0)
	{
	}

	private void UpdateState_Challenge(ShowTradeItem removeItem0)
	{
	}

	public void ShowCardGroupReward(ShowTradeItem removeItem0)
	{
	}

	public void DestroyThis()
	{
	}

	public void ResetPosition()
	{
	}
}
