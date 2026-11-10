using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Friends_LogIn : MonoBehaviour
{
	public UILabel lFriendsNum;

	public UILabel lGiftsNum;

	public UIButton btnInviteFriends;

	public UIButton btnGiveAllGifts;

	public UIWrapContentEx uiWrapContentEx;

	public GameObject oFrientItems;

	public UISprite btnGiveAllGiftsTop;

	public UI_WaitLoading uiWaitLoading;

	public UI_AnimationCtrl uiAnimationCtrl;

	public Dictionary<string, ThirdPlatformUserItem> FriendsFBInfo;

	public Dictionary<string, FriendInfo> OnlineFriends;

	public Dictionary<string, FriendInfo> offlineFriends;

	public List<UI_Friends_LogIn_Item> AllChildern;

	private int GetMaxGiftsOneDay;

	private bool hasSetScale;

	private bool buttonEnable;

	private List<CCFriendAskInfo> FriendAskInfos;

	[HideInInspector]
	public UI_Friends_LogIn_Item uiFriendsLogInItem;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void SetGiveGiftsAllState(bool CanClick)
	{
	}

	public void ShowFriend(object Param)
	{
	}

	public void InitFriendDate(object Param)
	{
	}

	public void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
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

	public List<CCFriendAskInfo> GetFriendAskInfo()
	{
		return null;
	}

	public void GetRespones(IList<CCFriendItem> GivegiftsFriends)
	{
	}

	public void GetBroadcastFriendsState(CCBroadcastFriendsStateResponse res)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void PlayerAnimSuccess()
	{
	}

	public void PlayerAnimFinish()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
