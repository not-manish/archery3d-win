using System.Collections.Generic;
using UnityEngine;

public class UI_GO_PanDian_Score : MonoBehaviour
{
	private UI_GO_PanDian uiPanDian;

	private UIGameOverParam uiParam;

	public GameObject objShootOff;

	public UILabel lLeftDisScore;

	public UILabel lRightDisScore;

	public UISprite lLeftWinSets;

	public UILabel lLeftSet1Score;

	public UILabel lLeftSet2Score;

	public UILabel lLeftSet3Score;

	public UISprite lRightWinSets;

	public UILabel lRightSet1Score;

	public UILabel lRightSet2Score;

	public UILabel lRightSet3Score;

	public UI_AnimationCtrl MyScoreAnimationCtrl;

	public UI_AnimationCtrl OppScoreffAnimationCtrl;

	public UI_AnimationCtrl[] LineAnims;

	public UI_AnimationCtrl shootoffAnimationCtrl;

	private int MyWinNum;

	private int OppWinNum;

	private int index;

	private int[] MySetScore;

	private int[] OppSetScore;

	private int SetNum;

	public void Show(UI_GO_PanDian _uiPanDian, UIGameOverParam _uiParam)
	{
	}

	public void bigScoreAnimfinish()
	{
	}

	public void PlayWinAnim()
	{
	}

	public void ScoreAnimfinish()
	{
	}

	private int GetSetScore(int index, List<int> Scores)
	{
		return 0;
	}

	private void SetSetsScore(UIGameOverParam uiParam)
	{
	}

	public void SetLineColor(int lineNum, int Winplayer)
	{
	}

	public void SetColor(UILabel playerLabel, UILabel OppPlayerLabel, Color winColor, Color loseColor, int WinPlayer)
	{
	}

	private void SetShootOffScore(UIGameOverParam uiParam)
	{
	}
}
