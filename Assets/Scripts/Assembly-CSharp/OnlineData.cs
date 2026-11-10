using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class OnlineData
{
	public enum TurnBaseStates
	{
		Null = 0,
		GamePlaying = 1,
		WaitingBegin = 2,
		GameFinished = 3
	}

	public enum PanDianTurnStates
	{
		Null = 0,
		YourTurn_First = 1,
		YourTurn_Second = 2,
		YourTurn_ShootOff = 3,
		RivalTurn_First = 4,
		RivalTurn_Second = 5,
		RivalTurn_ShootOff = 6
	}

	public enum ChongCiStates
	{
		Null = 0,
		GamePlaying = 1,
		WaitingBegin = 2,
		GameFinished = 3
	}

	public enum ChallengeStates
	{
		Null = 0,
		GamePlaying = 1,
		WaitingBegin = 2,
		GameFinished = 3
	}

	public static bool IsReconnected;

	public static long transIdForPvpRespose;

	public static CCPVPResponse ccPvpResponse;

	public static CCExchangeTurnResponse ccExchangeTurnResponse;

	public static CCGameOverResponse ccGameOverResponse;

	public static CCGameTimeBegin ccGameTimeBegin;

	public static CCGameTimeEnd ccGameTimeEnd;

	public static CCLeaveRoomResponse ccLeaveRoom;

	public static CCReMatchResponse ccRematchRoom;

	public static CCPlayAgainResponse ccPlayAgain;

	public static CCMatchResponse ccMatchRoom;

	public static CCMatchConfirmRequest_S2C ccMatchConfirm;

	public static CCLoginResponse ccLoginResponse;

	public static CCGamePlayingStatesResponse ccGameStatesResponse;

	public static CCRetryResponse ccRetry;

	public static CCEquipOperateResponse ccEquipOperateResponse;

	public static CCLeagueRankResponse ccLeagueRankResponse;

	public static CCGlobalRankResponse ccGlobalRankResponse;

	public static CCChallengeRankResponse ccChallengeRankResponse;

	public static CCChallengeBoardResponse ccChallengeBoardResponse;

	public static CCChestUnlockResponse ccChestUnlockResponse;

	public static CCChestOpenResponse ccChestOpenResponse;

	public static CCChestBuyTimeResponse ccChestBuyTimeResponse;

	public static CCArenaJoinResponse ccArenaJoinResponse;

	public static CCChallengeJoinResponse ccChallengeJoinResponse;

	public static CCUpdateShopResponse ccUpdateShopResponse;

	public static CCBuyShopResponse ccBuyShopResponse;

	public static CCSingleBuyObjectsResponse ccSingleBuyObjectsResponse;

	public static CCSingleLevelUpdateResponse ccSingleLevelUpdateResponse;

	public static CCSingleLevelRewardResponse ccSingleLevelRewardResponse;

	public static CCRestoreAccountResponse ccRestoreAccountResponse;

	public static CCGetThirdTokenResponse ccGetThirdTokenResponse;

	public static CCLinkThirdAccountResponse ccLinkThirdAccountResponse;

	public static CCQuestHandleResponse ccQuestHandleResponse;

	public static CCAchievementRewardResponse ccAchievementRewardResponse;

	public static CCGetMailsResponse ccGetMailsResponse;

	public static CCGetPlayerInfoResponse ccGetPlayerInfoResponse;

	public static CCHandleMailsResponse ccHandleMailsResponse;

	public static CCAskFriendsResponse ccAskFriendsResponse;

	public static CCBroadcastFriendsStateResponse ccBroadcastFriendsStateResponse;

	public static CCSevenDailyBonusResponse ccSevenDailyBonusResponse;

	public static CCGamblingRouletteResponse ccGamblingRouletteResponse;

	public static CCLimitedTimeBuyResponse ccLimitedTimeBuyResponse;

	public static CCWatchVideoSuccessResponse ccWatchVideoSuccessResponse;

	public static CCUpdatePlayerNameResponse ccUpdatePlayerNameResponse;

	public static CCIsInMatchingResponse isInMatchingResponse;

	public static CCTradeReponse ccTradeReponse;

	public static CCVideoNewResponse ccVideoNewResponse;

	public static CCConWinRefreshReponse ccConWinRefreshReponse;

	public static CCVideoExtraResponse ccVideoExtraResponse;

	public static CCVideoSubChestTimeResponse ccVideoSubChestTimeResponse;

	public static CCArenaGiveUpResponse ccArenaGiveUpResponse;

	public static CCDeleteAccountResponse ccDeleteAccountResponse;

	public static float TimeLeftGetTime;

	public static float TimeLeftFromServer;

	public static List<int> MyRounds;

	public static List<int> OppRounds;

	public static List<int> MyScores;

	public static List<int> OppScores;

	public static Dictionary<int, int> MyServeIdScores;

	public static Dictionary<int, int> OppServeIdScores;

	public static int GameResult;

	private static bool ShareTargets;

	private static List<int> myTargetsList;

	private static List<int> oppTargetsList;

	private static Dictionary<int, Vector3> hitLocalPos;

	public static bool isMyFirst;

	public static CCPlayer oppPLayer;

	public static bool isRobot;

	public static int aiNextRound;

	public static int aiNextScore;

	public static int aiRushShootTimes;

	public static List<int> robotScoreOrIndexList;

	public static List<int> robotBingoLineScoreIndexs;

	public static List<LineDir> robotCurBingoLineDirs;

	public static int target_range_id;

	public static List<int> bingo_my_5x5;

	public static List<int> bingo_opp_5x5;

	public static List<int> bingo_score_to_index_my_5x5;

	public static List<int> bingo_score_to_index_opp_5x5;

	public static GameResultType OnlineGameResult;

	public static bool is_new_chanllenge_score;

	public static List<int> ChestVideoRewardApiList;

	private static TurnBaseStates TurnBaseState;

	public static bool[] firstBingoScoreExist;

	public static bool[] secondBingoScoreExist;

	private static int[] firstBingoIndex;

	private static int[] secondBingoIndex;

	private static bool[] firstBingoScoreExistRobot;

	private const int LINE_COUNT = 12;

	private static int[,] LINE_INDEXS;

	private static bool HasInitLineDirs;

	private static List<List<LineDir>> INDEX_TO_LINE_DIRS;

	private static ChongCiStates chongCiState;

	private static ChallengeStates singleState;

	public static void ClearData()
	{
	}

	public static void ClearMatch()
	{
	}

	public static void SaveScore(bool isMy, IList<int> score)
	{
	}

	public static void SaveSeverIdScores(bool isMy, IList<CCKeyValueIntInt> ServeIdToScores)
	{
	}

	public static void SetShareTarget(bool _ShareTargets)
	{
	}

	public static bool GetIsShareTarget()
	{
		return false;
	}

	public static void SetMyServeTargetIDs(IList<int> MyTargetIDs)
	{
	}

	public static void SetMyServeTargetIDs(List<int> MyTargetIDs)
	{
	}

	public static List<int> GetMyTargetsList()
	{
		return null;
	}

	public static void SetOppServeTargetIDs(IList<int> OppTargetIDs)
	{
	}

	public static void SetOppServeTargetIDs(List<int> OppTargetIDs)
	{
	}

	public static List<int> GetOppTargetsList()
	{
		return null;
	}

	public static void SaveHitPos(CCPVPResponse response)
	{
	}

	public static void SaveRounds(bool isMy, IList<int> rounds)
	{
	}

	public static void GetScoreString(ref string myStr, ref string oppStr)
	{
	}

	public static int GetDisScoreCircle(int Score)
	{
		return 0;
	}

	public static int GetPointScoreCircle(int Score)
	{
		return 0;
	}

	public static string DisScoreToString(int Score)
	{
		return null;
	}

	public static void SetTurnBaseState(TurnBaseStates state)
	{
	}

	public static TurnBaseStates GetTurnBaseState()
	{
		return TurnBaseStates.Null;
	}

	public static int GetOnlineTenCircleContinueNums(PlayerType playerType)
	{
		return 0;
	}

	public static int GetOnlineMaxEqualTenCircleContinueNums(PlayerType playerType)
	{
		return 0;
	}

	public static bool IsPanDianGameOver()
	{
		return false;
	}

	public static OnlineNormalState GetPanDianState()
	{
		return OnlineNormalState.Null;
	}

	public static bool LastTurnIsMePanDian()
	{
		return false;
	}

	public static bool IsPanDianFinals()
	{
		return false;
	}

	public static UIScoreParam GetPanDianCurScoreParam()
	{
		return null;
	}

	public static GameResultType GetPanDianResult()
	{
		return GameResultType.Null;
	}

	public static void GetPanDianTrophy(ref List<TrophyState> myTrophy, ref List<TrophyState> oppTrophy)
	{
	}

	public static bool isPanDianScoreCountEquip()
	{
		return false;
	}

	public static void GetPanDianScoreString(ref string myStr, ref string oppStr, bool isNextRound)
	{
	}

	public static PanDianTurnStates GetPanDianTurnState()
	{
		return PanDianTurnStates.Null;
	}

	public static int GetPanDianSets(bool IsNextSets)
	{
		return 0;
	}

	public static bool ShouldShowSetsResult()
	{
		return false;
	}

	public static void GetPandDianLastSetScore(ref int MySetScore, ref int OppSetScore)
	{
	}

	public static UITargetPointParam GetPanDianTargetHitPos(bool isNextRound)
	{
		return null;
	}

	public static bool IsHuiHeGameOver()
	{
		return false;
	}

	public static OnlineNormalState GetHuiHeState()
	{
		return OnlineNormalState.Null;
	}

	public static bool LastTurnIsMeHuiHe()
	{
		return false;
	}

	public static bool IsHuiHeFinals()
	{
		return false;
	}

	public static UIScoreParam GetHuiHeCurScoreParam()
	{
		return null;
	}

	public static GameResultType GetHuiHeResult()
	{
		return GameResultType.Null;
	}

	public static void GetHuiHeScoreString(ref string myStr, ref string oppStr, bool isNextRound)
	{
	}

	public static void GetHuiHeRound(ref string roundStr, bool isNextRound)
	{
	}

	public static UITargetPointParam GetHuiHeTargetHitPos(bool isNextRound)
	{
		return null;
	}

	public static void SaveBingo5x5(bool isMy, IList<int> bingo5X5)
	{
	}

	public static bool IsBingoGameOver()
	{
		return false;
	}

	public static OnlineNormalState GetBingoState()
	{
		return OnlineNormalState.Null;
	}

	public static bool LastTurnIsMeBingo()
	{
		return false;
	}

	public static int GetBingoCurScore()
	{
		return 0;
	}

	public static GameResultType GetBingoResult()
	{
		return GameResultType.Null;
	}

	public static void GetBingoRound(ref string roundStr, bool isNextRound)
	{
	}

	private static bool BingoScoreValid(int score)
	{
		return false;
	}

	public static void GetBingoLineNumAndOrder(ref List<LineDir> lineDirs, ref List<LineState> lineStates)
	{
	}

	public static void GetBingoLineNumAndOrder(ref List<LineDir> lineDirs, ref List<LineState> lineStates, List<int> myBingo_5x5, List<int> oppBingo_5x5, List<int> myScores, List<int> oppScores)
	{
	}

	public static void GetBingoLineShouldShootNum(ref List<int> MyShowShootLined)
	{
	}

	public static void GetBingoLineShouldShootNum(ref List<int> MyShowShootLined, List<int> myBingo_5x5, List<int> oppBingo_5x5, List<int> myScores, List<int> oppScores)
	{
	}

	public static void isBingoAddNewLineofLastScore(ref List<bool> isMyLineAdd, ref List<bool> isOppLineAdd)
	{
	}

	public static void isBingoAddNewLineofLastScore(ref List<bool> isMyLineAdd, ref List<bool> isOppLineAdd, List<int> myBingo_5x5, List<int> oppBingo_5x5, List<int> myScores, List<int> oppScores)
	{
	}

	private static List<LineDir> CheckLineNum(int index, bool[] ScoreExist)
	{
		return null;
	}

	private static List<LineDir> GetScoreLineDirs(List<int> scoreIndexs, List<int> score5x5)
	{
		return null;
	}

	private static void InitIndexToLineDirs()
	{
	}

	private static List<int> GetLineIndexs(LineDir lineDir)
	{
		return null;
	}

	private static List<int> GetLineIndexs(List<LineDir> lineDirs)
	{
		return null;
	}

	private static List<LineDir> GetIndexToLineDirs(int index)
	{
		return null;
	}

	public static void CorrectRobotBingoScore(ref List<int> robotScoreIndexs, ref List<int> robotLineScoreIndexs, ref List<LineDir> robotCurBingoLineDirs, List<int> bingo_opp_5x5)
	{
	}

	public static AiEmojiStage GetAiEmojiStageState()
	{
		return AiEmojiStage.None;
	}

	public static UIScoreParam GetChongCiCurScoreParam()
	{
		return null;
	}

	public static string GetChongCiSumScoreStr(bool isMy, bool isNextRound)
	{
		return null;
	}

	public static void SetChongCiState(ChongCiStates state)
	{
	}

	public static ChongCiStates GetChongCiState()
	{
		return ChongCiStates.Null;
	}

	public static bool IsFinalsChongCi()
	{
		return false;
	}

	public static int GetChallengeCurScore()
	{
		return 0;
	}

	public static int GetChallengeRound(bool isNextRound)
	{
		return 0;
	}

	public static int GetChallengeSumScore()
	{
		return 0;
	}

	public static int GetChallengePlayAnims(int levelID)
	{
		return 0;
	}

	public static void SetChallengeState(ChallengeStates state)
	{
	}

	public static ChallengeStates GetChallengeState()
	{
		return ChallengeStates.Null;
	}

	public static bool IsLastArrowChallenge(int levelId, bool hasGetPvpRes)
	{
		return false;
	}

	private static int RandomAiScore()
	{
		return 0;
	}

	private static int GetAiScore_HuiHe()
	{
		return 0;
	}

	private static int GetAiScore_PanDian()
	{
		return 0;
	}

	private static int GetAiScore_ChongCi()
	{
		return 0;
	}

	private static int GetAiScore_Bingo()
	{
		return 0;
	}

	private static int GetAiShootScoreByIndex(int index)
	{
		return 0;
	}

	private static void GetAiAlreadyLightPoint(ref List<int> AlreadyLightLineIndexs, ref List<int> AlreadyLightAllIndexs, List<int> CurLineIndexs)
	{
	}

	public static int GetAiShootScore()
	{
		return 0;
	}

	public static float GetAiShootWaitingTime()
	{
		return 0f;
	}

	public static float GetAiShootWaitingTime_New()
	{
		return 0f;
	}

	public static void UpdateAiShootWaitingTime(ref FlexibleTimeRegulator timeRegualar)
	{
	}

	public static int RandomLevel1Score()
	{
		return 0;
	}

	public static string DebugListInt(List<int> DebugList)
	{
		return null;
	}
}
