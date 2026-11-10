using UnityEngine;

public class UI_Rank_MyItem_Panel : MonoBehaviour
{
	private Vector2 _initPanelClipOffset;

	private Vector3 _initPanelLocalPos;

	public UIPanel uiMyPanel;

	public Transform MyItem;

	public UIWrapContentEx uiWrapContentEx;

	private UIPanel uiScrollPanel;

	public FlexibleRealTimeRegulator m_tShowMyPanelRegulator;

	public FlexibleRealTimeRegulator m_tShowStartRegulator;

	public UISprite sMyItemBg;

	private Color32 topColor;

	private Color32 bottomColor;

	private ItemShowType MyItemShowType;

	private MyRankItemParam myRankItemParam;

	private float t;

	private bool isUpToShow;

	private Vector3 TargetPosition;

	private Vector3 NowPosition;

	public void Show()
	{
	}

	public void UpdateState(object param)
	{
	}

	private void Update()
	{
	}

	public void ScrollToMyItem()
	{
	}

	public void SetDrapPanelPosition()
	{
	}

	public void SetPosition(ItemShowType _myItemShowType)
	{
	}

	public void SetBgColor(ItemShowType _myItemShowType)
	{
	}
}
