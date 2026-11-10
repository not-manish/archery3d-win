using System;
using com.simple.proto;

public class UIRankGlobalItemParam
{
	public bool isItem;

	public bool isMe;

	public int rank;

	public CCRankItem rankItem;

	public int peopleNum;

	public Action ScorllBackAction;

	public UIRankGlobalItemParam(bool _isItem, bool _isMe, int _rank, CCRankItem _rankItem, Action _scorllBackAction = null)
	{
	}

	public UIRankGlobalItemParam(bool _isItem, int _peopleNum)
	{
	}
}
