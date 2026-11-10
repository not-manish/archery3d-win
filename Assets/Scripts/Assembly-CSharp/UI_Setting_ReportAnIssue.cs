using UnityEngine;

public class UI_Setting_ReportAnIssue : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSendEmail;

	public UIButton btnfo;

	public UILabel lEmailAddressTip;

	public UILabel ltitleTip;

	public UILabel lContentTip;

	public UIInput InEmailCode;

	public UIInput InTitle;

	public UIInput InContent;

	public UI_AnimationCtrl AnimEmailtip;

	public UI_AnimationCtrl AnimTitletip;

	public UI_AnimationCtrl AnimContenttip;

	public UILabel sendMsgLabel;

	public UILabel sendMsgLabelbg;

	private bool isSendingMsg;

	private float sendingTime;

	private int sendingTextState;

	private const int none_dot = 0;

	private const int one_dot = 1;

	private const int two_dot = 2;

	private const int three_dot = 3;

	private FlexibleRealTimeRegulator m_tRealtimeRegulator;

	public GetAcountType getAcountType;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private bool CheckEmailValid()
	{
		return false;
	}

	private bool CheckEmailCodeLocal()
	{
		return false;
	}

	private bool CheckTitleCodeLocal()
	{
		return false;
	}

	private bool CheckContentCodeLocal()
	{
		return false;
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

	private void InPutOnSelected(GameObject button, bool isSelect)
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
