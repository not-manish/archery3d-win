using UnityEngine;

public class UI_Rate : MonoInstance<UI_Rate>, UIBase
{
	public UI_Rate_endTips uiRateendTips;

	public UI_Rate_EnJoy uiRateEnJoy;

	public UI_Rate_FiveStar uiRateFiveStar;

	public UI_AnimationCtrl uiAnimationCtrl;

	public GameObject oBlack;

	private bool hasSetScale;

	private bool buttonEnable;

	public void Show(object param)
	{
	}

	public void UpdateState()
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
