using System.Collections.Generic;
using com.simple.proto;

public class MailGifts
{
	public int systemNewMails;

	public int friendNewMails;

	public float getMaxGifts;

	public float friendGiftMoney;

	public int mailMaxNum;

	public Dictionary<long, CCMailItem> friendMails;

	public Dictionary<long, CCMailItem> systemMails;

	public Dictionary<long, CCMailItem> systemUnDeleteMails;

	public Dictionary<long, CCMailItem> systemUnRewardMails;

	public Dictionary<long, int> allMailsItemState;

	public MailGifts()
	{
	}

	public MailGifts(int _friendNewMails, int _SystemNewMails, float _getMaxGifts, Dictionary<long, CCMailItem> _friendMails, Dictionary<long, CCMailItem> _systemMails, Dictionary<long, CCMailItem> _systemUnDeleteMails, Dictionary<long, CCMailItem> _systemUnRewardMails, Dictionary<long, int> _allMailsItemState)
	{
	}
}
