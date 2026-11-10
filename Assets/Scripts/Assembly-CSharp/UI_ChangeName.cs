using System;

public class UI_ChangeName : MonoInstance<UI_ChangeName>
{
	public UI_ChangeNameFailed uiChangeNameFailed;

	public UI_ChangeNameSuccess uiChangeNameSuccess;

	public UI_ChangeName_Confirm uiChangeNameConfirm;

	public UI_ChangeName_Waiting uiChangeNameWaiting;

	private bool hasSetScale;

	private Action HideAction;

	public void Show(object Param)
	{
	}

	public void Hide(object param)
	{
	}

	public void SetHideAction(Action action)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
