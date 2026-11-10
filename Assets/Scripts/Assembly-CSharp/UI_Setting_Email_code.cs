using UnityEngine;
using com.simple.proto;

public class UI_Setting_Email_code : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSendCode;

	public UIButton btGetCodeAgain;

	public UILabel lTitle;

	public UILabel lTitleBG;

	public UILabel lDescribe;

	public UILabel lBtnSend;

	public UILabel lBtnSendbg;

	public UILabel lReTryTime;

	public UILabel lEmailCode;

	public UIInput InCode;

	public HintType hHintType;

	private string emailCodeStr;

	private FlexibleRealTimeRegulator m_tRealtimeRegulator;

	public GetAcountType getAcountType;

	private bool hasSetScale;

	public CCThirdAccountItem ccThirdAccountItem;

	private bool buttonEnable;

	private bool isSendingMsg;

	public bool isTry;

	public float time;

	public string EmailCodeStr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	public void SetLableValue(string Title, string Descrise, string BtnSend)
	{
	}

	public virtual void OnSubmit()
	{
	}

	public void ShowWrongCode()
	{
	}

	public void Hide(object param)
	{
	}

	private void SeCureCode()
	{
	}

	private void ReGetCode()
	{
	}

	public virtual void EnableButtons()
	{
	}

	public virtual void DisableButtons()
	{
	}

	public void ClearAllEscape()
	{
	}

	public virtual void KeyEscapeClicked()
	{
	}

	private bool CheckCodeLocal()
	{
		return false;
	}

	public void OnReceiveResp()
	{
	}

	private void SetSending()
	{
	}

	private void SetSendEnable()
	{
	}

	public virtual void ButtonOnClicked(GameObject button)
	{
	}

	public void SetTryAgain(bool isEnable)
	{
	}

	private void Update()
	{
	}

	public virtual bool IsShowing()
	{
		return false;
	}
}
