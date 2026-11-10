using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_RankLeaguePopup_Promotion : MonoBehaviour
{
	public UIButton btSkip;

	public UIButton btContinue;

	public UI_Segment uiSegment;

	public UILabel lLeagueTimes;

	public FlexibleRealTimeRegulator m_tRegulator;

	public FlexibleRealTimeRegulator m_tWaitShowAnimRegulator;

	public List<UI_RankLeaguePopup_Promotion_Item> uiLists;

	public UI_RankLeaguePopup_Promotion_Item MyItem;

	private float MoveDownY;

	private UI_RankLeaguePopup uiRankPopup;

	private bool hasSetScale;

	private int LastRank;

	private int curBeginRank;

	private int curRank;

	private List<CCRankItem> CCRankItems;

	private long TimeLeft;

	private long oldServetime;

	private bool buttonEnable;

	private float startY;

	private void Start()
	{
	}

	public void Show(UI_RankLeaguePopup _uiRankPopup, object param)
	{
	}

	private void ChooseRelativeItems()
	{
	}

	public void Update()
	{
	}

	public void UpdateTime()
	{
	}

	public void UpdateState(bool isShowBigAnim = false)
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

	public void ResetPosition()
	{
	}

	public bool CheckLimitedTimeBuy()
	{
		return false;
	}
}
