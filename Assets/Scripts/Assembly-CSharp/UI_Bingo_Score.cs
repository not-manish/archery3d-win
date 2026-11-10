using System.Collections.Generic;
using UnityEngine;

public class UI_Bingo_Score : MonoBehaviour
{
	public UILabel lRoundNum;

	public UI_Bingo_LineScore uiLeftScore;

	public UI_Bingo_LineScore uiRightScore;

	public UI_Bingo_Trophy uiLeftTrophy;

	public UI_Bingo_Trophy uiRightTrophy;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public string curRound;

	private List<LineDir> myLineDirs;

	private List<LineDir> oppLineDirs;

	public void ShowStarEmpty()
	{
	}

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType, PlayerStandPart myStandPart, bool isShowStarAnim = false)
	{
	}

	private void Update()
	{
	}

	public void PlayStarAnim(UIStarParam PandianStar)
	{
	}

	public void ShowRealStar(List<LineDir> _myLineDirs, List<LineDir> _oppLineDirs, bool isShowAnim = false)
	{
	}

	public void GetBingoShouldShoot(List<int> MyShouldShootPoint)
	{
	}

	public void GetBingoHideScore()
	{
	}
}
