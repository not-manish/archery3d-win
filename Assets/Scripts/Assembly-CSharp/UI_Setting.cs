public class UI_Setting : MonoInstance<UI_Setting>, UIBase
{
	public UI_Setting_Normal uiSettingNormal;

	public UI_Setting_Offline uiSettingOffline;

	public UI_Setting_Others uiSettingOthers;

	private bool hasSetScale;

	public void Show(object param)
	{
	}

	public void ClearAllEscape()
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
