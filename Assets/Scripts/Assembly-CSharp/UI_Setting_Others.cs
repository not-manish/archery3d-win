using UnityEngine;

public class UI_Setting_Others : MonoBehaviour
{
	public UI_Setting_Credits uiSettingCredits;

	public UI_Setting_Hint uiSettingHint;

	public UI_Setting_WrongCode uiSettingWrongCode;

	public UI_Setting_Exit_Hint uiSettingExitHint;

	public UI_Setting_SecuredAccount uiSettingSecuredAccount;

	public UI_Setting_RecoveryMethod uiSettingRecoveryMethod;

	public UI_Setting_AddEmail uiSettingAddEmail;

	public UI_Setting_AddPhone uiSettingAddPhone;

	public UI_Setting_AddEmail_Success uiSettingAddEmailSuccess;

	public UI_Setting_Email_code uiSettingAddEmailCode;

	public UI_Setting_SendEmail_Info uiSettingSendEmailInfo;

	public UI_Setting_ReportAnIssue uiSettingReportAnIssue;

	public UI_Setting_Contact_Tips uiSettingContactTips;

	private bool hasSetScale;

	public SettingType settingType;

	private bool buttonEnable;

	public void Show(object Param)
	{
	}

	public void Hide(object param)
	{
	}

	public void ClearAllEscape()
	{
	}

	public void ExitShow()
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
