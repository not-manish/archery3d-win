using System.Collections.Generic;
using UnityEngine;

public class UI_GameMode_Challenge : MonoBehaviour
{
	private enum ChallangeVsState
	{
		Null = 0,
		IsOpening = 1,
		IsClosing = 2
	}

	public UILabel lTimeLeft;

	public GameObject OStartTimeLeft;

	public UILabel lStartTimeLeft;

	public UILabel lStartTimeLeftbg;

	public List<UIWidget> spriteContainers;

	public Color openColor;

	public Color closeColor;

	public UI_LogoScroll uilogogScroll;

	public UIWidget StartIn;

	public FlexibleRealTimeRegulator m_tRegulator;

	private ChallangeVsState challengeVsState;

	public void Show()
	{
	}

	private void Update()
	{
	}

	private void CheckChallengeState()
	{
	}

	private void SetChallengeTime(bool isOpening, long LeftTimeMil)
	{
	}

	private void SetChallengeState(ChallangeVsState state)
	{
	}

	public bool IsChallengeOpening()
	{
		return false;
	}

	public void SetTimeHide()
	{
	}
}
