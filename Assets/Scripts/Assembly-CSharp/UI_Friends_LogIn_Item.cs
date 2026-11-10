using System.Collections.Generic;
using UnityEngine;

public class UI_Friends_LogIn_Item : MonoBehaviour
{
	public UILabel lFriendsName;

	public string fbid;

	public string uid;

	public string fname;

	public bool hide_facebook_head;

	public int GiveGiftsNumber;

	public UIButton btnInviteMatch;

	public UIButton btnGiveGifts;

	public GameObject oBattleGray;

	public GameObject oGiftGray;

	public List<GameObject> LTips;

	public PlayerHeadShow playerHeadShow;

	public FriendInfo friendinfo;

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

	public void SetTips(int value)
	{
	}

	public string ShowOfflineTime(long timeLeftSecond)
	{
		return null;
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetResopones()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
