using UnityEngine;

public class UI_Setting_RecoveryMethod : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btRecoveFaceBook;

	public UIButton btRecoveEmail;

	public UIButton btRecovePhone;

	public UIButton btRecoveGuest;

	public UI_Setting_AddEmail uiRecoveEmail;

	public UI_Setting_AddPhone uiRecovePhone;

	public UI_Setting_GuestAccount_Hint uiRecoveGuest;

	private UI_Setting_Others uiSettingOthers;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Setting_Others _uiSettingOthers)
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

	public void ClearAllEscape()
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

	private void ToCreateNewAccount()
	{
	}

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName)
	{
	}
}
