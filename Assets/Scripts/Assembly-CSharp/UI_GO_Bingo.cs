using UnityEngine;

public class UI_GO_Bingo : MonoInstance<UI_GO_Bingo>, UIBase
{
	public UI_GO_Bingo_Score uiScore;

	[HideInInspector]
	public UI_GameOver uiGameOver;

	private UIGameOverParam uiParam;

	private BingoResultWindow curShowWind;

	public GameObject UI_BingoWinTips;

	public UI_AnimationCtrl AnimationCtrlWinTips;

	public UI_AnimationCtrl AnimationCtrlLine1;

	public UI_AnimationCtrl AnimationCtrlLine2;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool buttonEnable;

	public void Show(UI_GameOver _uiGameOver, UIGameOverParam _uiParam)
	{
	}

	public void AnimLine1Finish()
	{
	}

	public void AnimLine2Finish()
	{
	}

	private void Update()
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

	public bool IsShowing()
	{
		return false;
	}
}
