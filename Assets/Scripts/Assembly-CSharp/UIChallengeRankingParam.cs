using System;
using com.simple.proto;

public class UIChallengeRankingParam
{
	public ChallengeRankType rankType;

	public bool isOnBoard;

	public bool isMe;

	public int rank;

	public bool isShowRankIndex;

	public CCRankItem rankItem;

	public int middlePeopleNum;

	public int topPercent;

	public Action ScorllBackAction;

	public UIChallengeRankingParam(ChallengeRankType _rankType, bool _isMe = false, bool _isOnBoard = false, int _rank = 1, CCRankItem _rankItem = null, bool _isShowRankIndex = true, Action _scorllBackAction = null)
	{
	}

	public UIChallengeRankingParam(ChallengeRankType _rankType, int number)
	{
	}
}
