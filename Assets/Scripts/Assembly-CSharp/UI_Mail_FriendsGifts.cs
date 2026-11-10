using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Mail_FriendsGifts : MonoBehaviour
{
	public UIButton btCollectAll;

	public UILabel lMailNum;

	public UILabel lGetGiftNum;

	public UISprite btCollectAllbg;

	public UILabel lCollectAllbg;

	public UILabel lTitle;

	public UILabel lTitlebg;

	public List<UI_MailItem> MailItem;

	public Dictionary<long, CCMailItem> MailItemInfo;

	private List<long> allid;

	[HideInInspector]
	public float TodayGetReward;

	public MailGifts friendsGifts;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateMailItem(int newCount)
	{
	}

	public void UpdateDate()
	{
	}

	public void UpdateMailItemInfo(long id)
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

	public void GetRewardSuccess()
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
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
