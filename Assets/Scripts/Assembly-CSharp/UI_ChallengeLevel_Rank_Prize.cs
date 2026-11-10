using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Rank_Prize : MonoBehaviour
{
	public UI_ChallengeLevel_Rank_Prize_TopButton uiGroupButton;

	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public List<UIChallengeLevelParam> uiChallengeLevelParams;

	private bool hasSetScale;

	private UI_ChallengeLevel_Rank uiLeague;

	private ChallengeGroup challengeGroup;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel_Rank _uiLeague, ChallengeGroup myGroup)
	{
	}

	private void UpdateState(ChallengeGroup group)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GroupButtonClicked(ChallengeGroup group)
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
