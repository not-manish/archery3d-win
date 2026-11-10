using UnityEngine;
using com.simple.proto;

public class UI_Friends_NotifyInMenu : MonoBehaviour
{
	public UILabel lFriendsName;

	public string fbid;

	public string uid;

	public bool hide_facebook_head;

	public UILabel lGameType;

	public UILabel lGameLevel;

	public UILabel lPayGold;

	public UIButton btnStartNow;

	public UIButton btnAfterThis;

	public UIButton btnNotNow;

	public PlayerHeadShow playerHeadShow;

	public CCAskFriendsResponse friendinfo;

	private bool hasSetScale;

	private bool buttonEnable;

	private bool isAccept;

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

	public void GetResopones()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
