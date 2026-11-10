using com.simple.proto;

public class UI_FacebookLogin : MonoInstance<UI_FacebookLogin>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_FaceBook_Attention uiFaceBookAttention;

	public UI_Facebook_LinkTips uiFacebookLinkTips;

	public FaceBookInfo facebookInfo;

	private bool hasSetScale;

	private bool buttonEnable;

	public void Show(object FaceBookInfo)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void Hide(object param)
	{
	}

	private void UpdatePlayerNameSuccess()
	{
	}

	public void UpdatePlayerName()
	{
	}

	public void ShowFacebookLinkTips()
	{
	}

	public void ShowAttention(CCPlayer ccPlayer, bool isDeleteing, long deleteTime)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
