using System.Collections.Generic;
using UnityEngine;

public class UI_Rank_Challenge_Prize : MonoBehaviour
{
	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public List<UIChallengeLevelParam> uiChallengeLevelParams;

	private bool hasSetScale;

	private UI_Rank_Challenge uiRankChallenge;

	private ChallengeGroup challengeGroup;

	private void Awake()
	{
	}

	public void Show(UI_Rank_Challenge _uiRankChallenge, ChallengeGroup myGroup)
	{
	}

	private void UpdateState(ChallengeGroup group)
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void SetUpdateName()
	{
	}

	public void Hide(object param)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public int RealRankIndex(int topPrecent)
	{
		return 0;
	}
}
