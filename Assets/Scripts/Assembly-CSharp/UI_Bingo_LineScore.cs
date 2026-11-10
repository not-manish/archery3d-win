using System.Collections.Generic;
using UnityEngine;

public class UI_Bingo_LineScore : MonoBehaviour
{
	public GameObject oAllNumber;

	public GameObject oAllBack;

	public UILabel[] lScores;

	public UISprite[] sScoreBack;

	public UISprite[] oLines;

	public UISprite[] sSRedcoreBack;

	public UI_AnimationCtrl AnimRedcoreBack;

	private FlexibleRealTimeRegulator m_tTimeForwait;

	public void UpdateLineScore(bool isMy, bool[] isScoreExist, List<int> bingo5x5, List<LineDir> lineDir, bool ShowNum = false)
	{
	}

	public void ShowLightScore(bool isMy, List<int> ShouldShoot, List<int> bingo5x5)
	{
	}

	private void Update()
	{
	}

	public void HideRedBack()
	{
	}
}
