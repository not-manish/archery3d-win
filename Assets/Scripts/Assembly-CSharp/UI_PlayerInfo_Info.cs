using UnityEngine;

public class UI_PlayerInfo_Info : MonoBehaviour
{
	public UILabel lName;

	public UILabel lIDNum;

	public GameObject avatarNodeParentGo;

	public UILabel lCupNum;

	public UISprite sCup;

	public UISprite sCupbg;

	public UI_Segment uiSegment;

	public UILabel lLevel;

	public UILabel lLevelbg;

	public UIButton btChangeName;

	public GameObject ChangeNameTips;

	public UI_AnimationCtrl ChangeNameTipsAnim;

	public UILabel lChangeNameTips;

	public UIButton btFaceBook;

	public AvatarNodeSc avatarNodeSc;

	private void Start()
	{
	}

	public void ShowSelfInfo()
	{
	}

	public void ShowOtherInfo(PlayerData otherUserData, UserHeadData otherPlayerHead)
	{
	}

	public void ShowLevel(int segment)
	{
	}

	private void InitAvatar()
	{
	}

	private void UpdateSelfAvatar()
	{
	}

	private void UpdateOtherAvatar(UserHeadData otherUserData)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName)
	{
	}

	private void Update()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdateName(string NewName)
	{
	}
}
