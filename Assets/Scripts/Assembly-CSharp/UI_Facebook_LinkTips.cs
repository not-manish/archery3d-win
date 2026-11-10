using UnityEngine;

public class UI_Facebook_LinkTips : MonoBehaviour
{
	public UIButton btClose;

	public UISprite sLoading;

	private UI_FacebookLogin uiFacebookLogin;

	private FaceBookInfo facebookInfo;

	private float speed;

	public FlexibleTimeRegulator m_tMaxWaitingTimeRegulator;

	private bool hasReponse;

	private bool isLinkRequest;

	private bool hasSetScale;

	private bool isLoading;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_FacebookLogin _uiFacebookLogin)
	{
	}

	private void Update()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void LinkCureCode()
	{
	}

	private void RestoreCureCode()
	{
	}

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName, bool isLink)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
