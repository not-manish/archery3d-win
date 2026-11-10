using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Mail_SystemMail : MonoBehaviour
{
	public UILabel lTitle;

	public UILabel lTitlebg;

	public UILabel lMailNum;

	public List<UI_MailItem> MailItem;

	public Dictionary<long, CCMailItem> MailItemInfo;

	public Dictionary<long, CCMailItem> MailGetRewardItemInfo;

	private List<long> allid;

	public MailGifts SystemGifts;

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

	public void UpdateDeleteMailItemInfo(long id)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
