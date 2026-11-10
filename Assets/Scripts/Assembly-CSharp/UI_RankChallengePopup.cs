using UnityEngine;

public class UI_RankChallengePopup : MonoInstance<UI_RankChallengePopup>, UIBase
{
	public UITexture BG;

	public UI_RankChallengePopup_WeekResult uiWeekResult;

	private bool hasSetScale;

	private UIRankChallengePopupParam uiParam;

	private RankChallengePopupWindows RankChallengePopupWindows;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void ShowWindow(RankChallengePopupWindows _RankChallengePopupWindows)
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

	public void TabButtonClicked(RankChallengePopupWindows RankChallengePopupWindows)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
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
