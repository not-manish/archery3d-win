using UnityEngine;

public class UI_Rank : MonoInstance<UI_Rank>, UIBase
{
	public UI_Rank_Common uiCommon;

	public UI_Rank_League uiLeague;

	public UI_Rank_Global uiGlobal;

	public UI_Rank_Challenge uiChallenge;

	private bool hasSetScale;

	private UIRankParam uiParam;

	private RankWindows rankWindows;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void ShowWindow(RankWindows _rankWindows)
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

	public void TabButtonClicked(RankWindows rankWindows)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ResPonse()
	{
	}
}
