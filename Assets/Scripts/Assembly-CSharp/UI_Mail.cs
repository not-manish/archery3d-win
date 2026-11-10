using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Mail : MonoInstance<UI_Mail>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btCancal;

	public UIButton btFriendMails;

	public UILabel lFriendMails;

	public UILabel lFriendMailsNewNum;

	public UISprite sFriendMailsNewNum;

	public UIButton btSystemMail;

	public UILabel lSystemMail;

	public UILabel lSystemMailNewNum;

	public UISprite sSystemMailNewNum;

	public Color32 SelectColor;

	public Color32 NotSelectColor;

	public UI_Mail_FriendsGifts uiFriendMails;

	public UI_Mail_SystemMail uiSystemMail;

	public UI_MailDetail uiMailDetail;

	public UIWrapContentEx uiSystemWrapContentEx;

	public UIWrapContentEx uiFriendWrapContentEx;

	public MailGifts mailGifts;

	public UI_WaitLoading uiWaitLoading;

	[HideInInspector]
	public CCMailItem uiMailItem;

	private bool hasSetScale;

	public List<long> allSystemIds;

	public List<long> allFriendIds;

	private bool buttonEnable;

	private new void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateMailItemInfo(int mailtype, int count)
	{
	}

	public void ShowFriendGifts()
	{
	}

	public void ShowSystemGifts()
	{
	}

	public void OnInitializeSystemItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void OnInitializeFriendItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void SystemTabSelected()
	{
	}

	public void FriendTabSelected()
	{
	}

	public void ShowMailDetail(UI_MailItem _uiMailItem)
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

	public void GetMails()
	{
	}

	public bool GetRewardSuccess()
	{
		return false;
	}

	public void UpdateMailShowInfo(MailCtrl.MailState mileState)
	{
	}

	public void SetReadState(int type, int state)
	{
	}

	public void RemoveRewardMail(List<long> allId, Dictionary<long, CCMailItem> DeleteItem)
	{
	}

	public void RemoveSysytemRewardMail(Dictionary<long, CCMailItem> DeleteItem)
	{
	}

	public void ReFresh()
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
