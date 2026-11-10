using UnityEngine;

public class UI_Setting_SecuredAccount : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSecuredFaceBook;

	public UIButton btSecuredEmail;

	public UIButton btSecuredPhone;

	public GameObject oSecuredFaceBookGray;

	public GameObject oSecuredEmailGray;

	public GameObject oSecuredPhoneGray;

	public UI_Setting_AddEmail uiSecuredEmail;

	public UI_Setting_AddPhone uiSecuredPhone;

	private UI_Setting_Others uiSettingOthers;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Setting_Others _uiSettingOthers)
	{
	}

	public void UpdateInfo()
	{
	}

	private void SetBindTypeEnable(GameObject btnGo, GameObject btnHadLongin)
	{
	}

	private void SetBindTypeDisable(GameObject btnGo, GameObject btnHadLongin)
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

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
