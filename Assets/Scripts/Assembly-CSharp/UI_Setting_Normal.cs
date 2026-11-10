using System.Collections.Generic;
using UnityEngine;

public class UI_Setting_Normal : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSound;

	public UIButton btEffectMusic;

	public UIButton btVibra;

	public UIButton btNotify;

	public UIButton btTutorial;

	public UIButton btCredits;

	public UIButton btContactus;

	public UIButton btSecureYourAccount;

	public UIButton btRecoverExistAccount;

	public UIButton btTradeDetailsShow;

	public UIButton btPrivacyPolicy;

	public UIButton btTermsOfService;

	public UIButton btDeteleAccount;

	public UILabel lVersion;

	public List<UI_Setting_Toggle> settingToggle;

	public UI_Setting_Others uiSettingOthers;

	public UI_Setting_SetPosition uiSettingSetPosition;

	private bool hasSetScale;

	private UI_Setting uiSetting;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Setting _uiSetting)
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
}
