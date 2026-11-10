using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_MailDetail : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btCancal;

	public UIButton btCollect;

	public UILabel lCollect;

	public UILabel lCollectbg;

	public UIButton btDelete;

	public UILabel lDelete;

	public UILabel lDeleteBg;

	public UISprite sRewardBG;

	public UISprite sChestReward;

	public UISprite sMailReward;

	public UILabel lMailRewardNum;

	public UILabel lTitle;

	public UILabel lTitlebg;

	public UILabel lMailInfo;

	public UILabel lMailCollect;

	public long MailID;

	public CCMailItem mailDetailInfo;

	public static CCMailItem mailRequestAgainItemInfo;

	private UI_Mail uiMail;

	private bool hasSetScale;

	private bool buttonEnable;

	private List<long> collectID;

	private void Start()
	{
	}

	public void Show(object Param, UI_Mail _uiMail)
	{
	}

	public void UpdateInfo(CCMailItem _mailDetailInfo)
	{
	}

	public void ShowReward(RewardType rewardsNum)
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

	public void GetRewardSuccess()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdateMailShowInfo(bool issuccess)
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}
}
