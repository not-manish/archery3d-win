using UnityEngine;

public class UI_Common_LinkFacebook_tips : MonoInstance<UI_Common_LinkFacebook_tips>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btnConnect;

	public UIButton btnGuest;

	public UIButton btnClose;

	public UISprite sSelectImage;

	private string spriteTitle;

	public UISprite sTitleBg;

	private string spriteBg;

	public UISprite sFacebookBg;

	private string spriteCheckBg;

	public UISprite sShowAgainBg;

	private string spriteCheck;

	public UISprite sShowAgainSelect;

	public UIButton btnDontShowAgain;

	private FacebookLinkTipsTime facebookLinkTipsTime;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState()
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

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName)
	{
	}
}
