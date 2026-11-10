using System;
using UnityEngine;

public class UI_TopMoney_SettingAndMail : MonoBehaviour
{
	public UIButton BtTopSetting;

	public UIPanel pSettingAndMail;

	public UIButton BtMail;

	public UISprite sMailNewTips;

	public UILabel lMailNewTips;

	public BoxCollider boxMail;

	public UI_AnimationCtrl uiAnimationCtrl;

	private Action<ButtonType> ButtonCommonDelegate;

	public FlexibleRealTimeRegulator m_tWaitTime;

	private UITopMoneyParam uiParam;

	private void Start()
	{
	}

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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetMails()
	{
	}

	public void ShowNewTips(NewTipsType newTipsType, bool isShow, int num = 1)
	{
	}

	public void ShowNewMail(bool isShow, int num = 1)
	{
	}

	public void GetMailResponse()
	{
	}

	public void UpdateMailState()
	{
	}

	private void Update()
	{
	}

	private void hidethis()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
