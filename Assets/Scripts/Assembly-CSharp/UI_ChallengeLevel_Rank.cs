using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Rank : MonoInstance<UI_ChallengeLevel_Rank>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_ChallengeLevel_Rank_Common uiCommon;

	public UI_ChallengeLevel_Rank_GroupRule uiGroupRule;

	public UI_ChallengeLevel_Rank_Prize uiPrize;

	public UI_ChallengeLevel_Rank_Ranking uiRanking;

	public UI_ChallengeLevel_Rank_ScoreBoard uiScoreBoard;

	public UI_WaitLoading uiWaitLoading;

	public ChallengeGroup challengeGroup;

	private Dictionary<ChallengeGroup, int> ShowPrizeIndex;

	private bool hasSetScale;

	private UI_ChallengeLevel uiChallengeLevel;

	public UIChallengeRankParam uiParam;

	private ChallengeRankWindows challengeRankWindows;

	private bool buttonEnable;

	public Dictionary<ChallengeGroup, int> SetPrizeIndex
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel _uiChallengeLevel, object param)
	{
	}

	public void ShowWindow(ChallengeRankWindows _challengeRankWindows, object param)
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

	public void TabButtonClicked(ChallengeRankCommonWindow _ChallengeRankWindows)
	{
	}

	public void CloseButtonClicked()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ShowWaiting()
	{
	}

	public void HideWaitiing()
	{
	}
}
