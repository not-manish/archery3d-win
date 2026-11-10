using System.Collections.Generic;
using MMNet;
using UnityEngine;
using com.simple.proto;

public class SendMsgHandle : INetMessageCallback
{
	private NetMgr m_NetMgr;

	public bool Accept(int api)
	{
		return false;
	}

	public void HandleMessage(NetMessage responseMsg)
	{
	}

	public void OnTimeOut(WaittingResponseMessage msg)
	{
	}

	public SendMsgHandle(NetMgr netMgr)
	{
	}

	public void HeartbeatRequest(long SendTimeMil)
	{
	}

	public void Login(int api_request = 0)
	{
	}

	public void Matching(MatchType matchType, GameType gameType, int levelID, int levelIndex, string friend_uid)
	{
	}

	public void MatchingQuit()
	{
	}

	public void MatchConfirmRequest(bool isConfirmSuccess)
	{
	}

	public void IsInMatchingRequest(int MatchType, int GameType, int LevelId)
	{
	}

	public void RematchRequest()
	{
	}

	public long PvpRequest(ShootingTarget param, long transationId)
	{
		return 0L;
	}

	public void PvpAimRequest(PvpAimOperateType operateType, Vector3 playerAngle)
	{
	}

	public void PvpAimRequest(PvpAimOperateType operateType, int arrow_id)
	{
	}

	public void PvpLeaveRoomRequest()
	{
	}

	public void PvpPlayAgainRequest()
	{
	}

	public void GamePlayingStateRequest()
	{
	}

	public void TargetMoveTimeRequest()
	{
	}

	public void LoadAssetSuccessRequest()
	{
	}

	public void ChatRequest(int ID)
	{
	}

	public void RetryQuest()
	{
	}

	public void EquipOperateRequest(EquipType equipType, int typeID, int operateType, int param)
	{
	}

	public void LeagueRankeRequest(int leagueID)
	{
	}

	public void GlobalRankRequest()
	{
	}

	public void ChallengeRankRequest(int challenge_id, ChallengeGroup challengeGroup, bool isClear_playerdata_chal_show)
	{
	}

	public void ChallengeBoardRequest(string MyUid, string OppUid)
	{
	}

	public void UnlockChestRequest(int ChestIndex, int ChestKind, int ChestId)
	{
	}

	public void VideoSubChestTimeRequest(int ChestIndex, int ChestKind, int ChestId)
	{
	}

	public long OpenChestRequest(ChestOpenType openType, int ChestKind, int ChestId, int ChestIndex, long _TransactionId)
	{
		return 0L;
	}

	public void BuyTimeChestRequest(int ChestIndex, int ChestKind, int ChestId)
	{
	}

	public void ArenaJoinRequest(ArenaType arenaType)
	{
	}

	public void ChallengeJoinRequest(ChallengeGroup group)
	{
	}

	public void ShopUpdateRequest()
	{
	}

	public void BuyShopRequest(ShopBuyType shop_buy_type, int shop_buy_id, int shop_buy_index, CCBillData ccBillData)
	{
	}

	public void SingleBuyObjectsRequest(SingleBuyObjectType singleBuyType, int Id, int buyTimes)
	{
	}

	public void SingleLevelUpdateRequest(SingleData singleData)
	{
	}

	public void SingleGetRewardsRequest(int levelId)
	{
	}

	public void HandleQuestRequest(QuestHandleType questHandleType, int quest_index)
	{
	}

	public void GetAchRewardRequest(int bigtype, int smalltype)
	{
	}

	public void GetUserInfoRequest(string uid)
	{
	}

	public void GetHandleMailsRequest(int handle_type, List<long> mailIDs)
	{
	}

	public void GetMailRequest()
	{
	}

	public void GetThirdTokenRequest(bool isBindThirdAccount, int type, string accountId, string token)
	{
	}

	public void LinkThirdAccountRequest(int type, string accountId, string token, bool isFaceBook = false, string name = "")
	{
	}

	public void RestoreAccountRequest(int type, string accountId, string token, bool isFaceBook = false, string name = "")
	{
	}

	public void ChangeItemRequest(int itemId, string value)
	{
	}

	public void sevenDailyBonusRequest(bool isWatchvideo = false)
	{
	}

	public void AskFriendsRequest(string fb_name, FriendsCtrl.FriendsHandleTypes friendsHandleTypes, List<CCFriendAskInfo> friendsID, bool invite_response = false)
	{
	}

	public void AskFriendsRequest_AnswerInviting(FriendsCtrl.FriendsHandleTypes type, bool accept, string friend_uid, int gameType, int levelId)
	{
	}

	public long gamblingRouletteRequest(GamblingRouletteCtrl.RouletteType rouletteType, bool isVideoFree, long transationId)
	{
		return 0L;
	}

	public void limitedTimeBuyRequest(LimitedTimeBuyCtrl.HandleType handleType, LimitedTimeBuyCtrl.PackageType packageType, int packageId, int levelGrade, bool applyAllPack)
	{
	}

	public void HasShowRateRequest()
	{
	}

	public void UpdatePlayerNameRequest(string new_name)
	{
	}

	public void WatchVideoSuccessRequest()
	{
	}

	public void GetRandomSocialIdsReq()
	{
	}

	public void EmailSupportRequest(string playerEmailAddr, string title = "", string content = "")
	{
	}

	public void GetTenGamesChestRequest(int id, bool isGetYesterday)
	{
	}

	public void ReaskResponseRequest(int ResponseType)
	{
	}

	public void VideoFreeNewRequest(VideoFreeNewRequestType requireType, DailyGiftType dailyGiftType, bool isWatchVideo = false)
	{
	}

	public void TradeRequest()
	{
	}

	public void ConWinRefreshRequest()
	{
	}

	public void ArenaGiveUpRequest(ArenaType arenaType)
	{
	}

	public void AccountDeleteRequest()
	{
	}

	public void HandleTimeOut_LoginRequest(WaittingResponseMessage msg)
	{
	}

	public void HandleTimeOut_SpinRequest(WaittingResponseMessage msg)
	{
	}

	public void HandleTimeOut_GetRankBonusRequest(WaittingResponseMessage msg)
	{
	}
}
