using UnityEngine;

public class UI_ChallengeLevel_Rank_Common : MonoBehaviour
{
	public UIButton btPrizesLight;

	public UIButton btRankingLight;

	public UIButton btPrizes;

	public UIButton btRanking;

	public UIButton btClose;

	private UI_ChallengeLevel_Rank uiRank;

	private ChallengeRankCommonWindow rankCommonWindow;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel_Rank _uiRank, ChallengeRankCommonWindow _rankWindows)
	{
	}

	public void ShowWindow(ChallengeRankCommonWindow _rankWindows)
	{
	}

	public void KeyEscapeClicked()
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
}
