using System.Collections.Generic;
using UnityEngine;

public class UI_Pause_Setting : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSound;

	public UIButton btEffectMusic;

	public UIButton btVibra;

	public UIButton btExit;

	public List<UI_Setting_Toggle> settingToggle;

	public UI_Pause_Exit uiPauseExit;

	private UI_Pause uiPause;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Pause _uiPause)
	{
	}

	public void Hide(object param)
	{
	}

	public void KeyEscapeClicked()
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

	public bool IsShowing()
	{
		return false;
	}
}
