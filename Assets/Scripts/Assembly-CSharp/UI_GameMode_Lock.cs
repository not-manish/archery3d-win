using System.Collections.Generic;
using UnityEngine;

public class UI_GameMode_Lock : MonoBehaviour
{
	public GameObject oGameMode;

	public GameObject oGameModeLockTrophy;

	public GameObject oGameModeUnLockEffect;

	public GameObject oGameModeUnLockWhite;

	public ParticleSystem pLight;

	public ParticleSystem pStart;

	public UILabel lUnLockTrophy;

	public UILabel lUnLockTrophybg;

	public UIProgressBar uiProgressBar;

	public List<UIWidget> spriteContainers;

	public UI_AnimationCtrl uiGameModeLockAnim;

	public UI_AnimationCtrl uiBtnSclceShowAnim;

	public UI_AnimationCtrl uiTimeShowAnim;

	public UI_AnimationCtrl uiBlackColorAnim;

	private Color openColor;

	private Color closeColor;

	public GameType gameType;

	public bool isPlayAniming;

	private int oldPanelLevel;

	private ChangeLockAnimPanelLevel changeLockAnimPanelLevel;

	public UIPanel oGameModePanel;

	private FlexibleRealTimeRegulator m_tTimeRegulator;

	private UI_GameMode uiGameMode;

	public void Show(object Param)
	{
	}

	private void Update()
	{
	}

	public void PlayAnim(object Param)
	{
	}

	private void CheckChallengeState()
	{
	}

	public void BtnScaleAnimPlayEnd()
	{
	}

	public void PlayEnd()
	{
	}

	public void SetSprite(Color color)
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
