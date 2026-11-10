using System.Collections.Generic;
using UnityEngine;

public class UI_Rank_League_Rank : MonoBehaviour
{
	public UIButton btSegment;

	public UI_Segment uiSegment;

	public UILabel lSegment1;

	public UILabel lSegment2;

	public UILabel lTimeLeft;

	public UIScrollView uiScrollView;

	public UI_Rank_MyItem_Panel uiRankMyItemPanel;

	public UI_Rank_League_Item MyItem;

	public UIWrapContentEx uiWrapContentEx;

	public FlexibleRealTimeRegulator m_tRegulator;

	public List<UIRankLeagueItemParam> uiRankLeagueItemsParam;

	private const int MAX_COUNT = 100;

	private int MyCount;

	private bool hasSetScale;

	private UI_Rank_League uiLeague;

	private long TimeLeft;

	private long oldServetime;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(UI_Rank_League _uiLeague)
	{
	}

	private void AskLeagueRank()
	{
	}

	private void UpdateState()
	{
	}

	public void IsShowMyItem(PlayerData playerdate, int _myCount)
	{
	}

	public void ScrollBackAction()
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void Update()
	{
	}

	public void UpdateTime()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void LeagueRankResponse()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	public void SetUpdateName()
	{
	}
}
