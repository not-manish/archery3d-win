using System.Collections.Generic;
using MMNet;
using com.simple.proto;

public class RecMsgHandler_Global : INetMessageCallback
{
	private static Dictionary<long, float> dicId2SendTime;

	private float UpdateTargetMaxDeltaTime;

	private NetMgr m_NetMgr;

	private int count;

	public static void AddTransID(long TransId)
	{
	}

	public static void ClearTransID()
	{
	}

	public static float GetTransIdDeltaTime(long TransId)
	{
		return 0f;
	}

	public bool Accept(int msgCode)
	{
		return false;
	}

	public void HandleMessage(NetMessage msg)
	{
	}

	public void OnTimeOut(WaittingResponseMessage msg)
	{
	}

	public RecMsgHandler_Global(NetMgr netMgr)
	{
	}

	public void HandleHeartBeatResponse(NetMessage msg, float deltaTime)
	{
	}

	public void HandleLoginResponse(NetMessage msg, float deltaTime)
	{
	}

	public static void SetLimitedTimeBuy()
	{
	}

	public void HandleMatchingResponse(NetMessage msg)
	{
	}

	public void HandleMatchConfirmResponse(NetMessage msg)
	{
	}

	public void HandleLoadAssetSuccessResponse(NetMessage msg)
	{
	}

	public void HandleGamePlayingStateResponse(NetMessage msg)
	{
	}

	public void HandlePVPResponse(NetMessage msg, float deltaTime)
	{
	}

	public void HandlePVPAimResponse(NetMessage msg)
	{
	}

	public void HandleExchangeTurnResponse(NetMessage msg)
	{
	}

	public void HandleGameOverResponse(NetMessage msg)
	{
	}

	public void HandleGameTimeBeginResponse(NetMessage msg)
	{
	}

	public void HandleGameTimeEndResponse(NetMessage msg)
	{
	}

	public void HandleTargetMoveTimeResponse(NetMessage msg, float deltaTime, bool enforce)
	{
	}

	public void HandleChatResponse(NetMessage msg)
	{
	}

	public void HandleGetPlayerInfoResponse(NetMessage msg)
	{
	}

	public void HandleLeaveRoomResponse(NetMessage msg)
	{
	}

	public void HandlePlayAgainResponse(NetMessage msg)
	{
	}

	public void HandleRoundDataChangeResponse(NetMessage msg)
	{
	}

	public void HandleRoomRematchResponse(NetMessage msg)
	{
	}

	public void HandleRetryResponse(NetMessage msg)
	{
	}

	public void HandleEquipOperateResponse(NetMessage msg)
	{
	}

	public void HandleLeagueRankResponse(NetMessage msg)
	{
	}

	public void HandleGlobalRankResponse(NetMessage msg)
	{
	}

	public void HandleChallengeRankResponse(NetMessage msg)
	{
	}

	public void HandleChallengeBoardResponse(NetMessage msg)
	{
	}

	public void HandleUnlockChestResponse(NetMessage msg)
	{
	}

	public void HandleVideoSubChestTimeResponse(NetMessage msg)
	{
	}

	public void HandleBuyTimeChestResponse(NetMessage msg)
	{
	}

	public void HandleOpenChestResponse(NetMessage msg)
	{
	}

	public void HandleArenaJoinResponse(NetMessage msg)
	{
	}

	public void HandleChallengeJoinResponse(NetMessage msg)
	{
	}

	public void HandleUpdateShopResponse(NetMessage msg)
	{
	}

	public void HandleBuyShopResponse(NetMessage msg)
	{
	}

	public void HandleSingleBuyObjectsResponse(NetMessage msg)
	{
	}

	public void HandleSingleLevelUpdateResponse(NetMessage msg)
	{
	}

	public void HandleSingleLevelRewardResponse(NetMessage msg)
	{
	}

	public void HandleRestoreAccountResponse(NetMessage msg)
	{
	}

	public void HandleLinkThirdAccountResponse(NetMessage msg)
	{
	}

	public void HandleGetThirdTokenResponse(NetMessage msg)
	{
	}

	public void HandlePlayerQuestResponse(NetMessage msg)
	{
	}

	public void HandleGetAchRewardResponse(NetMessage msg)
	{
	}

	public void HandleGetUserInfoResponse(NetMessage msg)
	{
	}

	public void HandleGetMailResponse(NetMessage msg)
	{
	}

	public void HandleAllMailResponse(NetMessage msg)
	{
	}

	public void AskFriendsResponse(NetMessage msg)
	{
	}

	public void ServerBroadcastResponse(NetMessage msg)
	{
	}

	public void sevenDailyBonusReponse(NetMessage msg)
	{
	}

	public void gamblingRouletteReponse(NetMessage msg)
	{
	}

	public void limitedTimeBuyResponse(NetMessage msg)
	{
	}

	public void watchVideoSuccessReponse(NetMessage msg)
	{
	}

	public void VideoNewResponse(NetMessage msg)
	{
	}

	public void updatePlayerNameResponse(NetMessage msg)
	{
	}

	public void isInMatchingResponse(NetMessage msg)
	{
	}

	public void TradeListResponse(NetMessage msg)
	{
	}

	public void ConWinRefreshResponse(NetMessage msg)
	{
	}

	public void handleReaskReponse(NetMessage msg)
	{
	}

	public void handleArenaGiveUpResponse(NetMessage msg)
	{
	}

	public void handleVideoExtraResponse(NetMessage msg)
	{
	}

	private void handleVideoExtraResponse2(CCVideoExtraResponse res, CCPlayer player)
	{
	}

	public void HandleDeleteAccount(NetMessage msg)
	{
	}

	public bool testMulityRequest()
	{
		return false;
	}
}
