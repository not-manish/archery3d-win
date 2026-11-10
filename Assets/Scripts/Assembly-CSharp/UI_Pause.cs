public class UI_Pause : MonoInstance<UI_Pause>, UIBase
{
	public UI_Pause_Exit uiPauseExit;

	public UI_Pause_Setting uiPausSetting;

	private bool hasSetScale;

	private UIPauseParam uiParam;

	private bool buttonEnable;

	public void Show(object param)
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

	public bool IsShowing()
	{
		return false;
	}
}
