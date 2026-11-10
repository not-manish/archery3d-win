using System.Collections.Generic;
using UnityEngine;

public class UI_GO_HuiHe_Score : MonoBehaviour
{
	private UI_GO_HuiHe uiHuiHe;

	private UIGameOverParam uiParam;

	public GameObject objShootOff;

	public UILabel lLeftDisScore;

	public UILabel lRightDisScore;

	public GameObject oTwoDigits;

	public UISprite sLTwo10;

	public UISprite sLTwo1;

	public UISprite sRTwo10;

	public UISprite sRTwo1;

	public GameObject oTwoDigitsMy;

	public GameObject oTwoDigitsOpp;

	public GameObject oThreeDigits;

	public UISprite sLThree100;

	public UISprite sLThree10;

	public UISprite sLThree1;

	public UISprite sRThree100;

	public UISprite sRThree10;

	public UISprite sRThree1;

	public GameObject oThreeDigitsMy;

	public GameObject oThreeDigitsOpp;

	private UI_AnimationCtrl bigScoreAnimationCtrl;

	public UI_AnimationCtrl shootoffAnimationCtrl;

	public void Show(UI_GO_HuiHe _uiHuiHe, UIGameOverParam _uiParam)
	{
	}

	public void ClearData(int Scoredate = 0)
	{
	}

	public void bigScoreAnimfinish()
	{
	}

	public void PlayWinAnim()
	{
	}

	private int GetSetScore(int index, List<int> Scores)
	{
		return 0;
	}

	private void SetSetsScore(UIGameOverParam uiParam)
	{
	}

	private void SetShootOffScore(UIGameOverParam uiParam)
	{
	}

	public void SetColor(UILabel playerLabel, UILabel OppPlayerLabel, Color winColor, Color loseColor, int WinPlayer)
	{
	}
}
