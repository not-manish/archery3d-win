using UnityEngine;
using com.simple.proto;

public class UI_Setting_AddEmail : BaseWindow
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSendEmail;

	public UILabel sendMsgLabel;

	public UILabel sendMsgLabelbg;

	public UILabel lTitle;

	public UILabel lTitlebg;

	public UILabel lDescribe;

	public UIInput InEmailCode;

	public bool isBindThirdAccount;

	private bool isSendingMsg;

	private float sendingTime;

	private int sendingTextState;

	private const int none_dot = 0;

	private const int one_dot = 1;

	private const int two_dot = 2;

	private const int three_dot = 3;

	public UI_Setting_Email_code uiSettingAddEmailCode;

	private FlexibleRealTimeRegulator m_tRealtimeRegulator;

	private string emailCodeStr;

	public GetAcountType getAcountType;

	private bool buttonEnable;

	private CCPlayer toActUsedWindowSUserData;

	private CCThirdAccountItem thirdActItem;

	private new void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	public void SetLableValue(string Title, string Descrise)
	{
	}

	public virtual void OnSubmit()
	{
	}

	public void OnChange()
	{
	}

	private bool CheckCodeLocal()
	{
		return false;
	}

	public void ShowWrongCode()
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

	public void GetCode()
	{
	}

	public void OnReceiveResp()
	{
	}

	public void HideToShowAccountUsedWindow(CCPlayer sUserData)
	{
	}

	public void HideToInputIdtyWindow(bool isBindAct, CCThirdAccountItem thirdActItem)
	{
	}

	private void SetSendingState()
	{
	}

	private void SetSendEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateSendText()
	{
	}

	private void SetSendingText(int textState)
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
