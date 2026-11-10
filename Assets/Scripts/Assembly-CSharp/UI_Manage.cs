using System.Collections.Generic;
using UnityEngine;

public class UI_Manage : MonoBehaviour
{
	public delegate void InputEscapeLisener();

	public delegate void LoginLisener();

	public delegate void UpdatePlayerLisener(bool updateGoldAndMoney);

	public delegate void GetPlayerInfoLisener();

	public delegate bool MatchResponseLisener();

	public delegate bool MatchConfirmLisener();

	public delegate void GameStateResponseLisener();

	public delegate void LeaveRoomLisener();

	public delegate void PlayAgainLisener();

	public delegate void RoomRematchLisener();

	public delegate void RoundDataChangeLisener();

	public delegate void RetryLisener();

	public delegate void EquipOperateLisener();

	public delegate void LeagueRankLisener();

	public delegate void GlobalRankLisener();

	public delegate void ChallengeRankLisener();

	public delegate void ChallengeBoardLisener();

	public delegate void ChestBuyTimeLisener();

	public delegate bool ChestOpenLisener();

	public delegate void ArenaJoinLisener();

	public delegate void ChallengeJoinLisener();

	public delegate void UpdateShopLisener();

	public delegate bool BuyShopLisener();

	public delegate void SingleBuyObjectsLisener();

	public delegate void SingleLevelUpdateLisener();

	public delegate void SingleLevelRewardLisener();

	public delegate void ChallengePlayLevelLisener();

	public delegate void RestoreAccountResponseLisener();

	public delegate void GetThirdTokenResponseLisener();

	public delegate void LinkThirdAccountResponseLisener();

	public delegate bool QuestHandleResponseLisener();

	public delegate bool GetAchievementRewardResponseLisener();

	public delegate void GetMailsResponseLisener();

	public delegate bool HandleMailsResponseLisener();

	public delegate void AskFriendsResponseLisener();

	public delegate void ServerBroadcastResponseLisener();

	public delegate bool SevenDailyBonusResponseLisener();

	public delegate bool GamblingRouletteResponseLisener();

	public delegate bool LimitedTimeBuyResponseLisener();

	public delegate bool WatchVideoSuccessResponseLisener();

	public delegate void UpdatePlayerNameResponseLisener();

	public delegate void IsInMatchingResponseLisener();

	public delegate void EmailSupportResponseLisener();

	public delegate bool VideoNewSuccessResponseLisener();

	public delegate bool TradeListResponseLisener();

	public delegate bool ConWinRefreshResponseLisener();

	public delegate bool VideoExtraResponseLisener();

	public delegate void UpdateChestUnLockLisener();

	public delegate void VideoSubChestTimeLisener();

	public delegate bool ArenaGiveUpResponseLisener();

	public delegate void DeleteAccountResponseLisener();

	public Camera uiCamera;

	public Camera CoinGem3DCamera;

	public Camera RendtexTrueCamera;

	public Texture2D oldBg;

	public AtlasManage atlasManage;

	public UI_Common uiCommon;

	public UI_MainMenu_Creator uiMainMenuCreator;

	public UI_Friends_Creator uiFriendsCreator;

	public UI_ChestOpen_Creator uiChestOpenCreator;

	public UI_ChestInfo_Creator uiChestInfoCreator;

	public UI_GameMode_Creator uiGameModeCreator;

	public UI_OfflineLevel_Creator uiOfflineLevelCreator;

	public UI_LevelClassic_Creator uiLevelClassicCreator;

	public UI_LevelTimeMode_Creator uiLevelTimeModeCreator;

	public UI_BingoLevel_Creator uiBingoLevelCreator;

	public UI_ChallengeLevel_Creator uiChallengeLevelCreator;

	public UI_RankLeaguePopup_Creator uiRankLeaguePopupCreator;

	public UI_RankChallengePopup_Creator uiRankChallengePopupCreator;

	public UI_ArenaLevel_Creator uiArenaLevelCreator;

	public UI_ArenaStart_Creator uiArenaStartCreator;

	public UI_Pause_Creator uiPauseCreator;

	public UI_Rank_Creator uiRankCreator;

	public UI_Shop_Creator uiShopCreator;

	public UI_Setting_Creator uiSettingCreator;

	public UI_Equip_Creator uiEquipCreator;

	public UI_GameOver_Creator uiGameOverCreator;

	public UI_PanDian_Creator uiPanDianCreator;

	public UI_HuiHe_Creator uiHuiHeCreator;

	public UI_Bingo_Creator uiBingoCreator;

	public UI_ChongCi_Creator uiChongCiCreator;

	public UI_Offline_Creator uiSingleCreator;

	public UI_Challenge_Creator uiChallengeCreator;

	public UI_Matching_Creator uiMatchingCreator;

	public UI_Diamond_Creator uiDiamondCreator;

	public UI_Tips_Creator uiTipsCreator;

	public UI_RendtexTrueCamera_Creator uiRendtexTrueCameraCreator;

	public UI_CoinGemAnim_Creator uiCoinGemAnimCreator;

	public UI_Achievement_Creator uiAchievementCreator;

	public UI_Quest_Creator uiQuestCreator;

	public UI_Mail_Creator uiMailCreator;

	public UI_FaceBookLogin_Creator uiFaceBookLoginCreator;

	public UI_PlayerInfo_Creator uiPlayerInfoCreator;

	public UI_DailyBonus_Creator uiDailyBonusCreator;

	public UI_MiniGames_Creator uiMiniGamesCreator;

	public UI_OnSale_Creator uiOnSaleCreator;

	public UI_Loading_Creator uiLoadingCreator;

	public UI_Loading_Reconnect_Creator uiLoadingReconnectCreator;

	public UI_Guide_Creator uiGuideCreator;

	public UI_Rate_Creator uiRateCreator;

	public UI_ChangeName_Creator uiChangeNameCreator;

	public UI_1V1Game_Rules_Creator ui1V1GameRulesCreator;

	public UI_GetAchievementTips_Creator uiGetAchievementTipsCreator;

	public UI_SingleSale_Creator uiSingleSaleCreator;

	public UI_TransactionDetails_Creator uiTransactionDetailsCreator;

	public UI_DeleteAccount_Creator uiDeleteAccountCreator;

	private static UI_Manage instance;

	private bool isShowLoading;

	public List<InputEscapeLisener> inputEscapeLiseners;

	public List<LoginLisener> LoginLiseners;

	public List<UpdatePlayerLisener> updatePlayerLiseners;

	public List<GetPlayerInfoLisener> GetPlayerInfoLiseners;

	public List<MatchResponseLisener> MatchResponseLiseners;

	private bool is_match_waitting;

	public List<MatchConfirmLisener> MatchConfirmLiseners;

	public List<GameStateResponseLisener> GameStateResponseLiseners;

	public List<LeaveRoomLisener> LeaveRoomLiseners;

	public List<PlayAgainLisener> PlayAgainLiseners;

	public List<RoomRematchLisener> RoomRematchLiseners;

	public List<RoundDataChangeLisener> RoundDataChangeLiseners;

	public List<RetryLisener> RetryLiseners;

	public List<EquipOperateLisener> EquipOperateLiseners;

	public List<LeagueRankLisener> LeagueRankLiseners;

	public List<GlobalRankLisener> GlobalRankLiseners;

	public List<ChallengeRankLisener> ChallengeRankLiseners;

	public List<ChallengeBoardLisener> ChallengeBoardLiseners;

	public List<ChestBuyTimeLisener> ChestBuyTimeLiseners;

	public List<ChestOpenLisener> ChestOpenLiseners;

	public List<ArenaJoinLisener> ArenaJoinLiseners;

	public List<ChallengeJoinLisener> ChallengeJoinLiseners;

	public List<UpdateShopLisener> UpdateShopLiseners;

	public List<BuyShopLisener> BuyShopLiseners;

	public List<SingleBuyObjectsLisener> SingleBuyObjectsLiseners;

	public List<SingleLevelUpdateLisener> SingleLevelUpdateLiseners;

	public List<SingleLevelRewardLisener> SingleLevelRewardLiseners;

	public List<ChallengePlayLevelLisener> ChallengePlayLevelLiseners;

	public List<RestoreAccountResponseLisener> RestoreAccountResponseLiseners;

	public List<GetThirdTokenResponseLisener> GetThirdTokenResponseLiseners;

	public List<LinkThirdAccountResponseLisener> LinkThirdAccountResponseLiseners;

	public List<QuestHandleResponseLisener> QuestHandleResponseLiseners;

	public List<GetAchievementRewardResponseLisener> GetAchievementRewardResponseLiseners;

	public List<GetMailsResponseLisener> GetMailsResponseLiseners;

	public List<HandleMailsResponseLisener> HandleMailsResponseLiseners;

	public List<AskFriendsResponseLisener> AskFriendsResponseLiseners;

	public List<ServerBroadcastResponseLisener> ServerBroadcastResponseLiseners;

	public List<SevenDailyBonusResponseLisener> SevenDailyBonusResponseLiseners;

	public List<GamblingRouletteResponseLisener> GamblingRouletteResponseLiseners;

	public List<LimitedTimeBuyResponseLisener> LimitedTimeBuyResponseLiseners;

	public WatchVideoSuccessResponseLisener WatchVideoSuccessResponseLiseners;

	public List<UpdatePlayerNameResponseLisener> UpdatePlayerNameResponseLiseners;

	public List<IsInMatchingResponseLisener> IsInMatchingResponseLiseners;

	public List<EmailSupportResponseLisener> EmailSupportResponseLiseners;

	public VideoNewSuccessResponseLisener VideoNewSuccessResponseLiseners;

	public TradeListResponseLisener tradeListResponseLisener;

	public ConWinRefreshResponseLisener conWinRefreshResponseLisener;

	public VideoExtraResponseLisener videoExtraResponseLisener;

	public List<UpdateChestUnLockLisener> updateChestUnLockLiseners;

	public List<VideoSubChestTimeLisener> videoSubChestTimeLiseners;

	public ArenaGiveUpResponseLisener arenaGiveUpResponseLisener;

	public DeleteAccountResponseLisener deleteAccountResponseLisener;

	public static UI_Manage Instance => null;

	private void Awake()
	{
	}

	private void InitAllUI()
	{
	}

	private void InitAsync()
	{
	}

	public void InitFinished(AsyncLoadType finishType)
	{
	}

	public void HideAllExceptLoading()
	{
	}

	public void HandleMessage(UI_Manage_Message message, object param)
	{
	}

	public void PushInputEscapeLisener(InputEscapeLisener lisener)
	{
	}

	public void RemoveAllInputEscapeLisener(InputEscapeLisener lisener)
	{
	}

	public void PopInputEscapeLisener(InputEscapeLisener lisener)
	{
	}

	private void Update()
	{
	}

	private void SetShowUI()
	{
	}

	public void RegisteredLogin(LoginLisener lisener)
	{
	}

	public void UnregisteredLogin(LoginLisener lisener)
	{
	}

	public void LoginResponse()
	{
	}

	public void RegisteredUpdatePlayer(UpdatePlayerLisener lisener)
	{
	}

	public void UnregisteredUpdatePlayer(UpdatePlayerLisener lisener)
	{
	}

	public void UpdatePlayerResponse(bool updateGoldAndMoney = true)
	{
	}

	public void RegisteredGetPlayerInfo(GetPlayerInfoLisener lisener)
	{
	}

	public void UnregisteredGetPlayerInfo(GetPlayerInfoLisener lisener)
	{
	}

	public void GetPlayerInfoResponse()
	{
	}

	public void RegisteredMatchResponse(MatchResponseLisener lisener)
	{
	}

	public void UnregisteredMatchResponse(MatchResponseLisener lisener)
	{
	}

	public void SetMatchWaitting(bool matchWait)
	{
	}

	public bool MatchResponse()
	{
		return false;
	}

	public void RegisteredMatchConfirm(MatchConfirmLisener lisener)
	{
	}

	public void UnregisteredMatchConfirm(MatchConfirmLisener lisener)
	{
	}

	public bool MatchConfirmResponse()
	{
		return false;
	}

	public void RegisteredGameStateResponse(GameStateResponseLisener lisener)
	{
	}

	public void UnregisteredGameStateResponse(GameStateResponseLisener lisener)
	{
	}

	public void GameStateResponse()
	{
	}

	public void RegisteredLeaveRoom(LeaveRoomLisener lisener)
	{
	}

	public void UnregisteredLeaveRoom(LeaveRoomLisener lisener)
	{
	}

	public void LeaveRoomResponse()
	{
	}

	public void RegisteredPlayAgain(PlayAgainLisener lisener)
	{
	}

	public void UnregisteredPlayAgain(PlayAgainLisener lisener)
	{
	}

	public void PlayAgainResponse()
	{
	}

	public void RegisteredRoomRematch(RoomRematchLisener lisener)
	{
	}

	public void UnregisteredRoomRematch(RoomRematchLisener lisener)
	{
	}

	public void RoomRematchResponse()
	{
	}

	public void RegisteredRoundDataChange(RoundDataChangeLisener lisener)
	{
	}

	public void UnregisteredRoundDataChange(RoundDataChangeLisener lisener)
	{
	}

	public void RoundDataChangeResponse()
	{
	}

	public void HandleChatResopnse(int chatId, bool isMyself)
	{
	}

	public void RegisteredRetry(RetryLisener lisener)
	{
	}

	public void UnregisteredRetry(RetryLisener lisener)
	{
	}

	public void RetryResponse()
	{
	}

	public void RegisteredEquipOperate(EquipOperateLisener lisener)
	{
	}

	public void UnregisteredEquipOperate(EquipOperateLisener lisener)
	{
	}

	public void EquipOperateResponse()
	{
	}

	public void RegisteredLeagueRank(LeagueRankLisener lisener)
	{
	}

	public void UnregisteredLeagueRank(LeagueRankLisener lisener)
	{
	}

	public void LeagueRankResponse()
	{
	}

	public void RegisteredGlobalRank(GlobalRankLisener lisener)
	{
	}

	public void UnregisteredGlobalRank(GlobalRankLisener lisener)
	{
	}

	public void GlobalRankResponse()
	{
	}

	public void RegisteredChallengeRank(ChallengeRankLisener lisener)
	{
	}

	public void UnregisteredChallengeRank(ChallengeRankLisener lisener)
	{
	}

	public void ChallengeRankResponse()
	{
	}

	public void RegisteredChallengeBoard(ChallengeBoardLisener lisener)
	{
	}

	public void UnregisteredChallengeBoard(ChallengeBoardLisener lisener)
	{
	}

	public void ChallengeBoardResponse()
	{
	}

	public void RegisteredChestBuyTime(ChestBuyTimeLisener lisener)
	{
	}

	public void UnregisteredChestBuyTime(ChestBuyTimeLisener lisener)
	{
	}

	public void ChestBuyTimeResponse()
	{
	}

	public void RegisteredChestOpen(ChestOpenLisener lisener)
	{
	}

	public void UnregisteredChestOpen(ChestOpenLisener lisener)
	{
	}

	public bool ChestOpenResponse()
	{
		return false;
	}

	public void RegisteredArenaJoin(ArenaJoinLisener lisener)
	{
	}

	public void UnregisteredArenaJoin(ArenaJoinLisener lisener)
	{
	}

	public void ArenaJoinResponse()
	{
	}

	public void RegisteredChallengeJoin(ChallengeJoinLisener lisener)
	{
	}

	public void UnregisteredChallengeJoin(ChallengeJoinLisener lisener)
	{
	}

	public void ChallengeJoinResponse()
	{
	}

	public void RegisteredUpdateShop(UpdateShopLisener lisener)
	{
	}

	public void UnregisteredUpdateShop(UpdateShopLisener lisener)
	{
	}

	public void UpdateShopResponse()
	{
	}

	public void RegisteredBuyShop(BuyShopLisener lisener)
	{
	}

	public void UnregisteredBuyShop(BuyShopLisener lisener)
	{
	}

	public bool BuyShopResponse()
	{
		return false;
	}

	public void RegisteredSingleBuyObjects(SingleBuyObjectsLisener lisener)
	{
	}

	public void UnregisteredSingleBuyObjects(SingleBuyObjectsLisener lisener)
	{
	}

	public void SingleBuyObjectsResponse()
	{
	}

	public void RegisteredSingleLevelUpdate(SingleLevelUpdateLisener lisener)
	{
	}

	public void UnregisteredSingleLevelUpdate(SingleLevelUpdateLisener lisener)
	{
	}

	public void SingleLevelUpdateResponse()
	{
	}

	public void RegisteredSingleLevelReward(SingleLevelRewardLisener lisener)
	{
	}

	public void UnregisteredSingleLevelReward(SingleLevelRewardLisener lisener)
	{
	}

	public void SingleLevelRewardResponse()
	{
	}

	public void RegisteredChallengePlayLevel(ChallengePlayLevelLisener lisener)
	{
	}

	public void UnregisteredChallengePlayLevel(ChallengePlayLevelLisener lisener)
	{
	}

	public void ChallengePlayLevelResponse()
	{
	}

	public void RegisteredRestoreAccount(RestoreAccountResponseLisener lisener)
	{
	}

	public void UnregisteredRestoreAccount(RestoreAccountResponseLisener lisener)
	{
	}

	public void RestoreAccountResponse()
	{
	}

	public void RegisteredGetThirdToken(GetThirdTokenResponseLisener lisener)
	{
	}

	public void UnregisteredGetThirdToken(GetThirdTokenResponseLisener lisener)
	{
	}

	public void GetThirdTokenResponse()
	{
	}

	public void RegisteredLinkThirdAccount(LinkThirdAccountResponseLisener lisener)
	{
	}

	public void UnregisteredLinkThirdAccount(LinkThirdAccountResponseLisener lisener)
	{
	}

	public void LinkThirdAccountResponse()
	{
	}

	public void RegisteredQuestHandleResponse(QuestHandleResponseLisener lisener)
	{
	}

	public void UnregisteredQuestHandleResponse(QuestHandleResponseLisener lisener)
	{
	}

	public bool QuestHandleResponse()
	{
		return false;
	}

	public void RegisteredGetAchievementReward(GetAchievementRewardResponseLisener lisener)
	{
	}

	public void UnregisteredGetAchievementReward(GetAchievementRewardResponseLisener lisener)
	{
	}

	public bool GetAchievementRewardResponse()
	{
		return false;
	}

	public void RegisteredGetMails(GetMailsResponseLisener lisener)
	{
	}

	public void UnregisteredGetMails(GetMailsResponseLisener lisener)
	{
	}

	public void GetMailsRewardResponse()
	{
	}

	public void RegisteredHandleMails(HandleMailsResponseLisener lisener)
	{
	}

	public void UnregisteredHandleMails(HandleMailsResponseLisener lisener)
	{
	}

	public bool HandleMailsRewardResponse()
	{
		return false;
	}

	public void RegisteredAskFriends(AskFriendsResponseLisener lisener)
	{
	}

	public void UnregisteredAskFriends(AskFriendsResponseLisener lisener)
	{
	}

	public void AskFriendsResponse()
	{
	}

	public void RegisteredBroadcastFriendsState(ServerBroadcastResponseLisener lisener)
	{
	}

	public void UnregisteredBroadcastFriendsState(ServerBroadcastResponseLisener lisener)
	{
	}

	public void ServerBroadcastResponse()
	{
	}

	public void RegisteredSevenDailyBonus(SevenDailyBonusResponseLisener lisener)
	{
	}

	public void UnregisteredSevenDailyBonus(SevenDailyBonusResponseLisener lisener)
	{
	}

	public bool SevenDailyBonusResponse()
	{
		return false;
	}

	public void RegisteredGamblingRoulette(GamblingRouletteResponseLisener lisener)
	{
	}

	public void UnregisteredGamblingRoulette(GamblingRouletteResponseLisener lisener)
	{
	}

	public bool GamblingRouletteResponse()
	{
		return false;
	}

	public void RegisteredLimitedTimeBuy(LimitedTimeBuyResponseLisener lisener)
	{
	}

	public void UnregisteredLimitedTimeBuy(LimitedTimeBuyResponseLisener lisener)
	{
	}

	public bool LimitedTimeBuyResponse()
	{
		return false;
	}

	public void RegisteredWatchVideoSuccess(WatchVideoSuccessResponseLisener lisener)
	{
	}

	public void UnregisteredWatchVideoSuccess(WatchVideoSuccessResponseLisener lisener)
	{
	}

	public bool WatchVideoSuccessResponse()
	{
		return false;
	}

	public void RegisteredUpdatePlayerName(UpdatePlayerNameResponseLisener lisener)
	{
	}

	public void UnregisteredUpdatePlayerName(UpdatePlayerNameResponseLisener lisener)
	{
	}

	public void UpdatePlayerNameResponse()
	{
	}

	public void RegisteredIsInMatching(IsInMatchingResponseLisener lisener)
	{
	}

	public void UnregisteredIsInMatching(IsInMatchingResponseLisener lisener)
	{
	}

	public void IsInMatchingResponse()
	{
	}

	public void RegisteredEmailSupport(EmailSupportResponseLisener lisener)
	{
	}

	public void UnregisteredEmailSupport(EmailSupportResponseLisener lisener)
	{
	}

	public void EmailSupportResponse()
	{
	}

	public void RegisteredVideoNewSuccess(VideoNewSuccessResponseLisener lisener)
	{
	}

	public void UnregisteredVideoNewSuccess(VideoNewSuccessResponseLisener lisener)
	{
	}

	public bool VideoNewSuccessResponse()
	{
		return false;
	}

	public void RegisteredTradeList(TradeListResponseLisener lisener)
	{
	}

	public void UnregisteredTradeList(TradeListResponseLisener lisener)
	{
	}

	public bool TradeListResponse()
	{
		return false;
	}

	public void RegisteredConWinRefresh(ConWinRefreshResponseLisener lisener)
	{
	}

	public void UnregisteredConWinRefresh(ConWinRefreshResponseLisener lisener)
	{
	}

	public bool ConWinRefreshResponse()
	{
		return false;
	}

	public void RegisteredVideoExtra(VideoExtraResponseLisener lisener)
	{
	}

	public void UnregisteredVideoExtra(VideoExtraResponseLisener lisener)
	{
	}

	public bool VideoExtraResponse()
	{
		return false;
	}

	public void RegisteredUpdateChestUnLock(UpdateChestUnLockLisener lisener)
	{
	}

	public void UnregisteredUpdateChestUnLock(UpdateChestUnLockLisener lisener)
	{
	}

	public void UpdateChestUnLockResponse()
	{
	}

	public void RegisteredVideoSubChestTime(VideoSubChestTimeLisener lisener)
	{
	}

	public void UnregisteredVideoSubChestTime(VideoSubChestTimeLisener lisener)
	{
	}

	public void VideoSubChestTimeResponse()
	{
	}

	public void RegisteredArenaGiveUp(ArenaGiveUpResponseLisener lisener)
	{
	}

	public void UnregisteredArenaGiveUp(ArenaGiveUpResponseLisener lisener)
	{
	}

	public bool ArenaGiveUpResponse()
	{
		return false;
	}

	public void RegisteredDeleteAccount(DeleteAccountResponseLisener lisener)
	{
	}

	public void UnregisteredDeleteAccount(DeleteAccountResponseLisener lisener)
	{
	}

	public void DeleteAccountResponse()
	{
	}

	public Texture2D isChangeBackGround()
	{
		return null;
	}

	public void ChangeBackGround(UITexture BGTexture)
	{
	}
}
