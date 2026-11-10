using System.Collections.Generic;
using UnityEngine;

public class UI_Rank_Challenge : MonoBehaviour
{
	public UI_Rank_Challenge_Prize uiPrize;

	public UI_Rank_Challenge_Ranking uiRanking;

	public UIButton btAmateur;

	public UIButton btProfessional;

	public UIButton btExpert;

	public UIButton btMaster;

	public UIChangeWidgeColor wiAmateur;

	public UIChangeWidgeColor wiProfessional;

	public UIChangeWidgeColor wiExpert;

	public UIChangeWidgeColor wiMaster;

	public List<GameObject> BtnGroup;

	public UISprite sBoard;

	private int index;

	private bool hasSetScale;

	public UIButton btPrizesLight;

	public UIButton btRankingLight;

	public UIButton btPrizes;

	public UIButton btRanking;

	public UI_WaitLoading uiWaitLoading;

	private ChallengeGroup challengeGroupState;

	private Dictionary<ChallengeGroup, int> ShowPrizeIndex;

	private ChallengeRankCommonWindow challengeRankCommonWindow;

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

	public void Show(UI_Rank uiRank)
	{
	}

	public void ShowWindow(ChallengeRankCommonWindow _rankWindows)
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

	public void SetButtonState(ChallengeGroup _challengeGroupState)
	{
	}

	public void UpdateState()
	{
	}

	public void ShowWaiting()
	{
	}

	public void HideWaitiing()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void SetUpdateName()
	{
	}
}
