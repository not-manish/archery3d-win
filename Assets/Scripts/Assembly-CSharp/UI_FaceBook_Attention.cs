using UnityEngine;
using com.simple.proto;

public class UI_FaceBook_Attention : MonoBehaviour
{
	public UILabel lName;

	public UILabel lNamebg;

	public UILabel lIDNum;

	public UILabel lCupNum;

	public UISprite sCup;

	public UISprite sCupbg;

	public UILabel ldescribe1;

	public UILabel ldescribe2;

	public UILabel ldescribe3;

	public UIButton btBack;

	public UILabel lab_back;

	public UILabel lab_back1;

	public UIButton btRecover;

	public UILabel lab_Recover;

	public UILabel lab_Recover1;

	private long finalTime;

	private bool isDeleted;

	public UILabel lab_countDown;

	public PlayerHeadShow playerHeadShow;

	private UI_FacebookLogin uiFacebookLogin;

	private string RecoverPlayer;

	private string LinkPlayer;

	private CCPlayer ccPlayer;

	private long remaingTime;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_FacebookLogin _uiFacebookLogin, CCPlayer _ccPlayer, bool isDeleteing, long deleteTime)
	{
	}

	public void ShowSelfInfo(PlayerData otherData, bool isDeleteing, long deleteTime)
	{
	}

	private void Update()
	{
	}

	public void Recover()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void LogoutCallback(bool isSuccess)
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

	public void KeyEscapeClicked()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
