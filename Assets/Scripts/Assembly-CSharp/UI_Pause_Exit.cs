using UnityEngine;

public class UI_Pause_Exit : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btResume;

	public UIButton btExit;

	public UIButton btClose;

	private bool hasSetScale;

	private UI_Pause uiPause;

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
