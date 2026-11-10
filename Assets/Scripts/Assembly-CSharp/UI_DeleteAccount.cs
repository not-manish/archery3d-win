using UnityEngine;

public class UI_DeleteAccount : MonoInstance<UI_DeleteAccount>, UIBase
{
	public UI_AnimationCtrl openAnimCtrl;

	public UIButton btn_Close;

	public UIInput input;

	public UIButton btn_Delete;

	public UILabel lable_Delete;

	public UISprite s_Delete;

	public GameObject gPopWindow;

	public UI_AnimationCtrl animCtrl;

	public UIButton btn_OK;

	public UIButton btn_Cancel;

	public UILabel lab_Message;

	public UILabel lab_Title;

	public UILabel lab_Title1;

	public UILabel lab_Confirm;

	public UILabel lab_Confirm1;

	public PlayerHeadShow avatar;

	public UILabel lab_PlayerName;

	public UILabel lab_Cups;

	public UILabel lab_BindTip;

	public UISprite icon_Background;

	public GameObject gFB;

	public GameObject gGOOGLE;

	public GameObject gApple;

	public UILabel lab_Guest;

	private FlexibleTimeRegulator timeRegulator;

	private DeleteAccountPopWindowType currWindowType;

	private bool hasSetScale;

	private bool buttonEnable;

	private new void Awake()
	{
	}

	public void OnUpdate()
	{
	}

	private void StartTimeing(bool waitResponse = true)
	{
	}

	private void showWaitOfGetReward(bool isShow)
	{
	}

	private void OnDeleteAccount()
	{
	}

	public void OnOpen()
	{
	}

	private void RegisterBtnEvent()
	{
	}

	private void OnInputChange()
	{
	}

	public void SetButtonEnable(UIButton button, bool isCanclik)
	{
	}

	private void OnCloseClick(GameObject button)
	{
	}

	public void OnPressEscapeKey()
	{
	}

	private void OnDeleteClick(GameObject button)
	{
	}

	private void OnWindowOkClick(GameObject button)
	{
	}

	private void ClearInfoAndRestart()
	{
	}

	private void OnWindowCancelClick(GameObject button)
	{
	}

	private void SetPopWindowState(DeleteAccountPopWindowType type)
	{
	}

	public void ClearAllEscape()
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

	public bool IsShowing()
	{
		return false;
	}
}
