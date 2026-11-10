using System.Collections.Generic;
using UnityEngine;

public class UI_Friends_NoLogIn : MonoBehaviour
{
	public UILabel lTipsNotLink;

	private string NotLinkstr;

	public UILabel lTipsNotLongin;

	private string NotLongin;

	public UIButton btnConnectFB;

	public UILabel lConnectFB;

	public UILabel lConnectFBbg;

	public UILabel lChestName;

	public UILabel lChestNameBg;

	public UISprite sChest;

	public List<UISprite> sAdSPrites;

	public PlayerAcountState playerAcountState;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateDate()
	{
	}

	public void Hide()
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

	public bool IsShowing()
	{
		return false;
	}
}
