using System;
using UnityEngine;

public class UI_1v1_Level_UnlockAnimCtrl : MonoBehaviour
{
	private enum UnLockAnimState
	{
		Show = 0,
		PlayLockAnim = 1,
		PlayBreakAnim = 2
	}

	public GameObject oGameLevelUnLockBg;

	public GameObject oGameLevelUnLockAnim;

	public GameObject oGameLevelUnLockEffect;

	public ParticleSystem pChainExplosion;

	public ParticleSystem pPayLine;

	public ParticleSystem pBlingBling;

	public ParticleSystem pStart;

	public UISprite sLogo;

	public UI_AnimationCtrl uiGameLevelBgAnim;

	public UI_AnimationCtrl uiGameLevelUnLockAnim;

	public bool isPlayAniming;

	private FlexibleRealTimeRegulator m_tTimeRegulator;

	private FlexibleRealTimeRegulator m_tTimeRegulatorBackDepth;

	private int oldDepth;

	private UI_Level1v1_Unlock uiLevel1v1Unlock;

	private UnLockAnimState unLockAnimState;

	private Action AnimEndaction;

	public void Show(object Param)
	{
	}

	private void FixedUpdate()
	{
	}

	public void PlayAnimEffect()
	{
	}

	public void PlayAnim()
	{
	}

	public void PlayEnd()
	{
	}

	public void SetAction(Action animEndaction)
	{
	}

	public void Hide()
	{
	}

	public void ResetAnim()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
