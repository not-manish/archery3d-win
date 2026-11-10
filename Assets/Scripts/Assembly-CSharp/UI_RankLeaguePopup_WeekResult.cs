using System.Collections.Generic;
using UnityEngine;

public class UI_RankLeaguePopup_WeekResult : MonoBehaviour
{
	public UIButton btContinue;

	public UI_Segment uiSegment;

	public UILabel lSegment1;

	public UILabel lSegment2;

	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public UI_WaitLoading uiWaitLoading;

	public UI_Rank_MyItem_Panel uiRankMyItemPanel;

	public UI_Rank_League_Item MyItem;

	public int MyCount;

	private const int MAX_COUNT = 100;

	private UI_RankLeaguePopup uiRankPopup;

	public List<UIRankLeagueItemParam> uiRankLeagueItemsParam;

	private bool hasUpdate;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(UI_RankLeaguePopup _uiRankPopup, object param)
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

	public bool IsShowing()
	{
		return false;
	}

	public void ReconnectLoginSuccess()
	{
	}
}
