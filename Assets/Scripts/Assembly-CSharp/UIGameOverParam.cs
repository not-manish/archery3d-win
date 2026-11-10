using System.Collections.Generic;
using com.simple.proto;

public class UIGameOverParam
{
	public PvpType pvpType;

	public GameType gameType;

	public int levelId;

	public bool IsGiveUp;

	public CCPlayer oppPlayer;

	public bool isMyFirst;

	public List<int> MyRounds;

	public List<int> OppRounds;

	public List<int> MyScores;

	public List<int> OppScores;

	public List<int> MyBingo5x5;

	public List<int> OppBingo5x5;

	public int GameCostTime;

	public int GameResult;

	public int CoinRewardSum;

	public int CoinRewardMy;

	public int CoinRewardOpp;

	public bool HasRewardChest;

	public int chest_kind;

	public int chest_id;

	public int TrophyRewardMy;

	public int TrophyRewardOpp;

	public int TrophyBeforeMy;

	public int TrophyBeforeOpp;
}
