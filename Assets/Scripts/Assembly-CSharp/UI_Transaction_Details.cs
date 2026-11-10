using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Transaction_Details : MonoInstance<UI_Transaction_Details>, UIBase
{
	public IList<CCTradeTable> AllTradeList;

	public UIButton btnClose;

	public Transform Parent;

	public UI_TradeItem uiTradeItem_First;

	public List<UI_TradeItem> AllShowItem;

	private Dictionary<string, ShowTradeTable> AllShowTradeTable;

	public UIPanel uiScrollView;

	private float uiScrollViewStartY;

	public UIScrollBar uiScrollBar;

	public UI_WaitLoading uiWaitLoading;

	private float firstHeight;

	private bool isDragScrollBar;

	public UIWrapContentExNew uiWrapContentExNew;

	public UI_AnimationCtrl uiAnimCtrl;

	private bool hasSetScale;

	private bool buttonEnable;

	private float TotalPanelHeight;

	private int BgAddGetIconheight;

	private int BgStartheight;

	private int AddY;

	private int ShowLineDistance;

	private int STitleheight;

	private new void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void ButtonOnDrag(GameObject button, Vector2 moveDistance)
	{
	}

	public bool GetTradeResponse()
	{
		return false;
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public Dictionary<string, ShowTradeTable> ResetTradeTableData(IList<CCTradeTable> allTradeList)
	{
		return null;
	}

	public void ShowAllItems(Dictionary<string, ShowTradeTable> allShowTradeTable)
	{
	}

	public void reSetPosition(Dictionary<string, ShowTradeTable> allShowTables, List<int> Position)
	{
	}

	public void resetScrollPosition()
	{
	}

	public void UpdateState(float onePanelHeight, float totalHeight)
	{
	}

	private void Update()
	{
	}

	private void SetValue()
	{
	}

	private void SetValueFinish()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void SendRequest()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	public void AddItems(ShowTradeTable showTradeTable, ref int totalHight)
	{
	}

	public void ShowGoodsItem(List<ShowTradeItem> showTradeTableItem, List<ShowTradeItem> removeItem, ref int totalHight)
	{
	}

	public bool isShowGetLeftObj(ShowTradeItem item)
	{
		return false;
	}
}
