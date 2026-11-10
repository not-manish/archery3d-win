using System.Collections.Generic;
using MMNet;
using UnityEngine;
using com.simple.proto;

public class NetMgr : BaseNetMgr
{
	public static GameOnlineState gameOnlineState;

	private static NetMgr _instance;

	private NetConnectMgr m_NetConnectMgr;

	private NetQualityMgrByHeartbeat m_NetQualityMgr;

	private LoginMgr m_LoginMgr;

	public DelayEventManager delayEventMgr;

	private WaittingResponseMessageMgr m_WaittingResponseMsgMgr;

	private SendMsgHandle sendMsgHandler;

	private INetMessageCallback recMsgHandler_Golbal;

	private INetMessageCallback recMsgHandler_PlayScene;

	public static NetMgr Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public NetConnectMgr M_NetConnectMgr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public NetQualityMgrByHeartbeat M_NetQualityMgr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LoginMgr M_LoginMgr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SendMsgHandle SendMsgHandle => null;

	public static bool IsOfflineState()
	{
		return false;
	}

	public void SetGameOnlineState(GameOnlineState onlineState)
	{
	}

	public void Init()
	{
	}

	public override void Update()
	{
	}

	public void Connect()
	{
	}

	public new void Close()
	{
	}

	public override void ConnectSuccess()
	{
	}

	public override void ConnectFailed()
	{
	}

	public bool IsConnected()
	{
		return false;
	}

	public void HeartbeatRequest(long SendTimeMil)
	{
	}

	public void LoginRequest(int api_request = 0)
	{
	}

	public void MatchingRequest(MatchType matchType, GameType gameType, int levelID, int levelIndex = 1, string friend_uid = "undefined")
	{
	}

	public void MatchingQuitRequest()
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

	public long PvpRequest(ShootingTarget param, long transationId = -1L)
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

	public void ChatRequest(int index)
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

	public void RetryQuest()
	{
	}

	public void EquipOperateRequest(EquipType equipType, int typeID, int operateType, int param = 0)
	{
	}

	public void LeagueRankeRequest(int leagueId)
	{
	}

	public void ChallengeRankRequest(int leagueId, ChallengeGroup challengeGroup, bool isClear_playerdata_chal_show = false)
	{
	}

	public void GlobalRankRequest()
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

	public long OpenChestRequest(ChestOpenType openType, int ChestKind, int ChestId, int ChestIndex, long TransactioonId = -1L)
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

	public void BuyShopRequest(ShopBuyType shop_buy_type, int shop_buy_id, int shop_buy_index, CCBillData ccBillData = null)
	{
	}

	public void SingleBuyObjectsRequest(SingleBuyObjectType singleBuyType, int Id, int buyTimes = 0)
	{
	}

	public void SingleLevelUpdateRequest(SingleData singleData)
	{
	}

	public void SingleGetRewardsRequest(int levelid)
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

	public void GetMailRequest()
	{
	}

	public void GetHandleMailsRequest(int handle_type, List<long> mailIDs)
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

	public void sevenDailyBonusRequest(bool isWatchvideo = false)
	{
	}

	public long gamblingRouletteRequest(GamblingRouletteCtrl.RouletteType rouletteType, bool isVideoFree = false, long transationId = -1L)
	{
		return 0L;
	}

	public void limitedTimeBuyRequest(LimitedTimeBuyCtrl.HandleType handleType, LimitedTimeBuyCtrl.PackageType packageType, int packageId = 0, int levelGrade = -1)
	{
	}

	public void limitedTimeBuyRequest(LimitedTimeBuyCtrl.HandleType handleType, LimitedTimeBuyCtrl.PackageType packageType, bool applyAllPacks)
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

	public void ReaskResponseRequest(int Responsetype)
	{
	}

	public void AskFriendsRequest(string fb_name, FriendsCtrl.FriendsHandleTypes friendsHandleTypes, List<CCFriendAskInfo> friendsID, bool invite_response = false)
	{
	}

	public void AskFriendsRequest_AnswerInviting(FriendsCtrl.FriendsHandleTypes type, bool accept, string friend_uid, int gameType, int levelId)
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

	public long Request(int msgCode, byte[] content, int time_out, long transationId = -1L)
	{
		return 0L;
	}

	public float OnRecResponseMessage(NetMessage msg)
	{
		return 0f;
	}

	public void Init_MsgHandler()
	{
	}

	public void SetMsgCallBack_PlayScene()
	{
	}

	public void UnRegisterMsgCallBack_Global()
	{
	}
}
