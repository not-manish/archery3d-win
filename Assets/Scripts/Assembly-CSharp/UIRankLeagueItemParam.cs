using System;
using com.simple.proto;

public class UIRankLeagueItemParam
{
	public LeagueRankType rankType;

	public bool isMe;

	public int index;

	public CCRankItem rankItem;

	public Action ScorllBackAction;

	public UIRankLeagueItemParam(LeagueRankType _rankType, bool _isMe = false, int _index = 1, CCRankItem _rankItem = null, Action _scorllBackAction = null)
	{
	}
}
