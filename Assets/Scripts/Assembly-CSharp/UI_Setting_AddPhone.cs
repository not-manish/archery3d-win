using UnityEngine;
using com.simple.proto;

public class UI_Setting_AddPhone : BaseWindow
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btSendPhone;

	public UILabel sendMsgLabel;

	public UILabel sendMsgLabelbg;

	public UILabel lTitle;

	public UILabel lTitlebg;

	public UILabel lDescribe;

	public GameObject popBtnGo;

	public GameObject popIcon;

	public UILabel lpopShow;

	public GameObject popContentGo;

	public UIScrollView scrollView;

	public UIInput InPhoneCode;

	public UI_Setting_Email_code uiSettingAddEmailCode;

	private bool isSendingMsg;

	private IDDCfgData iddCfgData;

	public UIWrapContentEx wrapContentEx;

	public bool isBindThirdAccount;

	private float sendingTime;

	private int sendingTextState;

	private const int none_dot = 0;

	private const int one_dot = 1;

	private const int two_dot = 2;

	private const int three_dot = 3;

	private const int phone_no_max_num = 15;

	private FlexibleRealTimeRegulator m_tRealtimeRegulator;

	public GetAcountType getAcountType;

	private bool hasSetScale;

	private float timeAccu;

	private bool buttonEnable;

	private CCPlayer toActUsedWindowSUserData;

	private CCThirdAccountItem thirdActItem;

	private new void Awake()
	{
	}

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

	public void ShowWrongCode()
	{
	}

	public void Hide(object param)
	{
	}

	private void PlayWindowShowAnim()
	{
	}

	private void OnFinishWindowShowAnim()
	{
	}

	private void PlayWindowHideAnim()
	{
	}

	private void OnFinishWindowHideAnim()
	{
	}

	private new void OnFinishAppearing()
	{
	}

	public new void SetWindowTouchable(bool value)
	{
	}

	private new void OnFinishDisappearing()
	{
	}

	private void RebuildScrollView()
	{
	}

	private bool IsUpdateByFixedTime()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateSendText()
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

	private void ToAccountUsedWindow()
	{
	}

	public void HideToInputIdtyWindow(bool isBindAct, CCThirdAccountItem thirdActItem)
	{
	}

	private void SetSendingText(int textState)
	{
	}

	public char OnValidateText(string text, int charIndex, char addedChar)
	{
		return '\0';
	}

	private static bool IsCharValid(char c)
	{
		return false;
	}

	public void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	private void SetSendingState()
	{
	}

	private void SetSendEnable()
	{
	}

	private bool LocalCheckPhoneNumRight()
	{
		return false;
	}

	private void SetPopBtnDown(bool isDown)
	{
	}

	public void OnClickRegionItem(IDDCfgData pData)
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
