using UnityEngine;

public class UI_RankLeaguePopup : MonoInstance<UI_RankLeaguePopup>, UIBase
{
	public UITexture BG;

	public UI_RankLeaguePopup_Promoted uiSegmentPromoted;

	public UI_RankLeaguePopup_Promotion uiRankPromotion;

	public UI_RankLeaguePopup_WeekResult uiWeekResult;

	public UI_RankLeaguePopup_Segment uiCurSegment;

	private bool hasSetScale;

	private UIRankLeaguePopupParam uiParam;

	private bool buttonEnable;

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

	public bool IsShowing()
	{
		return false;
	}

	public bool ChestOpenResponse()
	{
		return false;
	}
}
