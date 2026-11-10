using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_List : MonoBehaviour
{
	private UI_ChallengeLevel uiChallengeLevel;

	public List<UI_ChallengeLevel_Item> uiLists;

	public UIButton btRank;

	public UILabel lSumScore;

	public UILabel lSumTime;

	public UILabel lTimeLeft;

	public UIButton btBack;

	private bool hasSetScale;

	private bool buttonEnable;

	public void Show(UI_ChallengeLevel _uiChallengeLevel)
	{
	}

	private void CreateItems(List<GameType> listGameTypes)
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateTime()
	{
	}

	public void LevelClicked(int levelID, int levelIndex, ChallengeLevelItemState state)
	{
	}

	private void Start()
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

	public void ShowLevelInfo(int levelID)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool MatchingResponse()
	{
		return false;
	}
}
