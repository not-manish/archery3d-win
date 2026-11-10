using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayer : GeneratedMessageLite<CCPlayer, CCPlayer.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayer, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayer result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayer MessageBeingBuilt => null;

			public override CCPlayer DefaultInstanceForType => null;

			public bool HasId => false;

			public string Id
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasToken => false;

			public string Token
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasThirdAccount => false;

			public CCUserAccount ThirdAccount
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasName => false;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasFacebookId => false;

			public string FacebookId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasHideFacebookPhoto => false;

			public bool HideFacebookPhoto
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasCoin => false;

			public long Coin
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasGem => false;

			public long Gem
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasArenaLowCard => false;

			public int ArenaLowCard
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArenaHighCard => false;

			public int ArenaHighCard
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPurToken => false;

			public string PurToken
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasIsAdFree => false;

			public bool IsAdFree
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasIsRobot => false;

			public bool IsRobot
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasGetTrophy => false;

			public long GetTrophy
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasEquipData => false;

			public CCEquipData EquipData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasClassicData => false;

			public CCClassicData ClassicData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasRushData => false;

			public CCRushData RushData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasBingoData => false;

			public CCBingoData BingoData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasArenaData => false;

			public CCArenaData ArenaData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChallengeData => false;

			public CCChallengeData ChallengeData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChestClassicData => false;

			public CCChestClassicData ChestClassicData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasShopData => false;

			public CCShopData ShopData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLeagueData => false;

			public CCLeagueData LeagueData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSingleData => false;

			public CCSingleData SingleData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasAchievementData => false;

			public CCAchievementData AchievementData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasVideoFreeData => false;

			public CCVideoFreeData VideoFreeData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasStatisticData => false;

			public CCStatisticData StatisticData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasStateData => false;

			public CCPlayerStateData StateData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasFriendsData => false;

			public CCPlayerFriendsData FriendsData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSevenDailyBonus => false;

			public CCSevenDailyBonus SevenDailyBonus
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasGamblingRoulette => false;

			public CCGamblingRoulette GamblingRoulette
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLimitedTimeBuy => false;

			public CCLimitedTimeBuy LimitedTimeBuy
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasTutorialFinished => false;

			public bool TutorialFinished
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasHasShownRate => false;

			public bool HasShownRate
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasContinueLoseGames => false;

			public int ContinueLoseGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasQuestData => false;

			public CCQuestData QuestData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasMatchTimes => false;

			public int MatchTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGameModeState => false;

			public CCPlayerGameModeState GameModeState
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasHasGetFbGift => false;

			public bool HasGetFbGift
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasLastUpgradeRewardId => false;

			public int LastUpgradeRewardId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastChangeNameMil => false;

			public long LastChangeNameMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasActionStats => false;

			public CCPlayerActionStats ActionStats
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasCurCliVersion => false;

			public string CurCliVersion
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<int> LTBEquipTypeIdsList => null;

			public int LTBEquipTypeIdsCount => 0;

			public IPopsicleList<int> LTBBuyedIdsList => null;

			public int LTBBuyedIdsCount => 0;

			public bool HasPayScoreLeft => false;

			public int PayScoreLeft
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBuyEquipScoreLeft => false;

			public int BuyEquipScoreLeft
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasUpgradeEquipScoreLeft => false;

			public int UpgradeEquipScoreLeft
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasUpCliVer => false;

			public string UpCliVer
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<string> LastMatchAiNamesList => null;

			public int LastMatchAiNamesCount => 0;

			public bool HasConWinChest => false;

			public CCPlayerConWinChest ConWinChest
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasAbTest => false;

			public int AbTest
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasVideoFreeNew => false;

			public CCVideoFreeNew VideoFreeNew
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChestExtra => false;

			public CCChestExtra ChestExtra
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCPlayer cloneFrom)
			{
			}

			private CCPlayer PrepareBuilder()
			{
				return null;
			}

			public override Builder Clear()
			{
				return null;
			}

			public override Builder Clone()
			{
				return null;
			}

			public override CCPlayer BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayer other)
			{
				return null;
			}

			public override Builder MergeFrom(ICodedInputStream input)
			{
				return null;
			}

			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				return null;
			}

			public Builder SetId(string value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}

			public Builder SetToken(string value)
			{
				return null;
			}

			public Builder ClearToken()
			{
				return null;
			}

			public Builder SetThirdAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder SetThirdAccount(CCUserAccount.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeThirdAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder ClearThirdAccount()
			{
				return null;
			}

			public Builder SetName(string value)
			{
				return null;
			}

			public Builder ClearName()
			{
				return null;
			}

			public Builder SetFacebookId(string value)
			{
				return null;
			}

			public Builder ClearFacebookId()
			{
				return null;
			}

			public Builder SetHideFacebookPhoto(bool value)
			{
				return null;
			}

			public Builder ClearHideFacebookPhoto()
			{
				return null;
			}

			public Builder SetCoin(long value)
			{
				return null;
			}

			public Builder ClearCoin()
			{
				return null;
			}

			public Builder SetGem(long value)
			{
				return null;
			}

			public Builder ClearGem()
			{
				return null;
			}

			public Builder SetArenaLowCard(int value)
			{
				return null;
			}

			public Builder ClearArenaLowCard()
			{
				return null;
			}

			public Builder SetArenaHighCard(int value)
			{
				return null;
			}

			public Builder ClearArenaHighCard()
			{
				return null;
			}

			public Builder SetPurToken(string value)
			{
				return null;
			}

			public Builder ClearPurToken()
			{
				return null;
			}

			public Builder SetIsAdFree(bool value)
			{
				return null;
			}

			public Builder ClearIsAdFree()
			{
				return null;
			}

			public Builder SetIsRobot(bool value)
			{
				return null;
			}

			public Builder ClearIsRobot()
			{
				return null;
			}

			public Builder SetGetTrophy(long value)
			{
				return null;
			}

			public Builder ClearGetTrophy()
			{
				return null;
			}

			public Builder SetEquipData(CCEquipData value)
			{
				return null;
			}

			public Builder SetEquipData(CCEquipData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeEquipData(CCEquipData value)
			{
				return null;
			}

			public Builder ClearEquipData()
			{
				return null;
			}

			public Builder SetClassicData(CCClassicData value)
			{
				return null;
			}

			public Builder SetClassicData(CCClassicData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeClassicData(CCClassicData value)
			{
				return null;
			}

			public Builder ClearClassicData()
			{
				return null;
			}

			public Builder SetRushData(CCRushData value)
			{
				return null;
			}

			public Builder SetRushData(CCRushData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRushData(CCRushData value)
			{
				return null;
			}

			public Builder ClearRushData()
			{
				return null;
			}

			public Builder SetBingoData(CCBingoData value)
			{
				return null;
			}

			public Builder SetBingoData(CCBingoData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeBingoData(CCBingoData value)
			{
				return null;
			}

			public Builder ClearBingoData()
			{
				return null;
			}

			public Builder SetArenaData(CCArenaData value)
			{
				return null;
			}

			public Builder SetArenaData(CCArenaData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeArenaData(CCArenaData value)
			{
				return null;
			}

			public Builder ClearArenaData()
			{
				return null;
			}

			public Builder SetChallengeData(CCChallengeData value)
			{
				return null;
			}

			public Builder SetChallengeData(CCChallengeData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChallengeData(CCChallengeData value)
			{
				return null;
			}

			public Builder ClearChallengeData()
			{
				return null;
			}

			public Builder SetChestClassicData(CCChestClassicData value)
			{
				return null;
			}

			public Builder SetChestClassicData(CCChestClassicData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestClassicData(CCChestClassicData value)
			{
				return null;
			}

			public Builder ClearChestClassicData()
			{
				return null;
			}

			public Builder SetShopData(CCShopData value)
			{
				return null;
			}

			public Builder SetShopData(CCShopData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeShopData(CCShopData value)
			{
				return null;
			}

			public Builder ClearShopData()
			{
				return null;
			}

			public Builder SetLeagueData(CCLeagueData value)
			{
				return null;
			}

			public Builder SetLeagueData(CCLeagueData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeLeagueData(CCLeagueData value)
			{
				return null;
			}

			public Builder ClearLeagueData()
			{
				return null;
			}

			public Builder SetSingleData(CCSingleData value)
			{
				return null;
			}

			public Builder SetSingleData(CCSingleData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeSingleData(CCSingleData value)
			{
				return null;
			}

			public Builder ClearSingleData()
			{
				return null;
			}

			public Builder SetAchievementData(CCAchievementData value)
			{
				return null;
			}

			public Builder SetAchievementData(CCAchievementData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeAchievementData(CCAchievementData value)
			{
				return null;
			}

			public Builder ClearAchievementData()
			{
				return null;
			}

			public Builder SetVideoFreeData(CCVideoFreeData value)
			{
				return null;
			}

			public Builder SetVideoFreeData(CCVideoFreeData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeVideoFreeData(CCVideoFreeData value)
			{
				return null;
			}

			public Builder ClearVideoFreeData()
			{
				return null;
			}

			public Builder SetStatisticData(CCStatisticData value)
			{
				return null;
			}

			public Builder SetStatisticData(CCStatisticData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStatisticData(CCStatisticData value)
			{
				return null;
			}

			public Builder ClearStatisticData()
			{
				return null;
			}

			public Builder SetStateData(CCPlayerStateData value)
			{
				return null;
			}

			public Builder SetStateData(CCPlayerStateData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStateData(CCPlayerStateData value)
			{
				return null;
			}

			public Builder ClearStateData()
			{
				return null;
			}

			public Builder SetFriendsData(CCPlayerFriendsData value)
			{
				return null;
			}

			public Builder SetFriendsData(CCPlayerFriendsData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeFriendsData(CCPlayerFriendsData value)
			{
				return null;
			}

			public Builder ClearFriendsData()
			{
				return null;
			}

			public Builder SetSevenDailyBonus(CCSevenDailyBonus value)
			{
				return null;
			}

			public Builder SetSevenDailyBonus(CCSevenDailyBonus.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeSevenDailyBonus(CCSevenDailyBonus value)
			{
				return null;
			}

			public Builder ClearSevenDailyBonus()
			{
				return null;
			}

			public Builder SetGamblingRoulette(CCGamblingRoulette value)
			{
				return null;
			}

			public Builder SetGamblingRoulette(CCGamblingRoulette.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeGamblingRoulette(CCGamblingRoulette value)
			{
				return null;
			}

			public Builder ClearGamblingRoulette()
			{
				return null;
			}

			public Builder SetLimitedTimeBuy(CCLimitedTimeBuy value)
			{
				return null;
			}

			public Builder SetLimitedTimeBuy(CCLimitedTimeBuy.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeLimitedTimeBuy(CCLimitedTimeBuy value)
			{
				return null;
			}

			public Builder ClearLimitedTimeBuy()
			{
				return null;
			}

			public Builder SetTutorialFinished(bool value)
			{
				return null;
			}

			public Builder ClearTutorialFinished()
			{
				return null;
			}

			public Builder SetHasShownRate(bool value)
			{
				return null;
			}

			public Builder ClearHasShownRate()
			{
				return null;
			}

			public Builder SetContinueLoseGames(int value)
			{
				return null;
			}

			public Builder ClearContinueLoseGames()
			{
				return null;
			}

			public Builder SetQuestData(CCQuestData value)
			{
				return null;
			}

			public Builder SetQuestData(CCQuestData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeQuestData(CCQuestData value)
			{
				return null;
			}

			public Builder ClearQuestData()
			{
				return null;
			}

			public Builder SetMatchTimes(int value)
			{
				return null;
			}

			public Builder ClearMatchTimes()
			{
				return null;
			}

			public Builder SetGameModeState(CCPlayerGameModeState value)
			{
				return null;
			}

			public Builder SetGameModeState(CCPlayerGameModeState.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeGameModeState(CCPlayerGameModeState value)
			{
				return null;
			}

			public Builder ClearGameModeState()
			{
				return null;
			}

			public Builder SetHasGetFbGift(bool value)
			{
				return null;
			}

			public Builder ClearHasGetFbGift()
			{
				return null;
			}

			public Builder SetLastUpgradeRewardId(int value)
			{
				return null;
			}

			public Builder ClearLastUpgradeRewardId()
			{
				return null;
			}

			public Builder SetLastChangeNameMil(long value)
			{
				return null;
			}

			public Builder ClearLastChangeNameMil()
			{
				return null;
			}

			public Builder SetActionStats(CCPlayerActionStats value)
			{
				return null;
			}

			public Builder SetActionStats(CCPlayerActionStats.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeActionStats(CCPlayerActionStats value)
			{
				return null;
			}

			public Builder ClearActionStats()
			{
				return null;
			}

			public Builder SetCurCliVersion(string value)
			{
				return null;
			}

			public Builder ClearCurCliVersion()
			{
				return null;
			}

			public int GetLTBEquipTypeIds(int index)
			{
				return 0;
			}

			public Builder SetLTBEquipTypeIds(int index, int value)
			{
				return null;
			}

			public Builder AddLTBEquipTypeIds(int value)
			{
				return null;
			}

			public Builder AddRangeLTBEquipTypeIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearLTBEquipTypeIds()
			{
				return null;
			}

			public int GetLTBBuyedIds(int index)
			{
				return 0;
			}

			public Builder SetLTBBuyedIds(int index, int value)
			{
				return null;
			}

			public Builder AddLTBBuyedIds(int value)
			{
				return null;
			}

			public Builder AddRangeLTBBuyedIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearLTBBuyedIds()
			{
				return null;
			}

			public Builder SetPayScoreLeft(int value)
			{
				return null;
			}

			public Builder ClearPayScoreLeft()
			{
				return null;
			}

			public Builder SetBuyEquipScoreLeft(int value)
			{
				return null;
			}

			public Builder ClearBuyEquipScoreLeft()
			{
				return null;
			}

			public Builder SetUpgradeEquipScoreLeft(int value)
			{
				return null;
			}

			public Builder ClearUpgradeEquipScoreLeft()
			{
				return null;
			}

			public Builder SetUpCliVer(string value)
			{
				return null;
			}

			public Builder ClearUpCliVer()
			{
				return null;
			}

			public string GetLastMatchAiNames(int index)
			{
				return null;
			}

			public Builder SetLastMatchAiNames(int index, string value)
			{
				return null;
			}

			public Builder AddLastMatchAiNames(string value)
			{
				return null;
			}

			public Builder AddRangeLastMatchAiNames(IEnumerable<string> values)
			{
				return null;
			}

			public Builder ClearLastMatchAiNames()
			{
				return null;
			}

			public Builder SetConWinChest(CCPlayerConWinChest value)
			{
				return null;
			}

			public Builder SetConWinChest(CCPlayerConWinChest.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeConWinChest(CCPlayerConWinChest value)
			{
				return null;
			}

			public Builder ClearConWinChest()
			{
				return null;
			}

			public Builder SetAbTest(int value)
			{
				return null;
			}

			public Builder ClearAbTest()
			{
				return null;
			}

			public Builder SetVideoFreeNew(CCVideoFreeNew value)
			{
				return null;
			}

			public Builder SetVideoFreeNew(CCVideoFreeNew.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeVideoFreeNew(CCVideoFreeNew value)
			{
				return null;
			}

			public Builder ClearVideoFreeNew()
			{
				return null;
			}

			public Builder SetChestExtra(CCChestExtra value)
			{
				return null;
			}

			public Builder SetChestExtra(CCChestExtra.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestExtra(CCChestExtra value)
			{
				return null;
			}

			public Builder ClearChestExtra()
			{
				return null;
			}
		}

		private static readonly CCPlayer defaultInstance;

		private static readonly string[] _cCPlayerFieldNames;

		private static readonly uint[] _cCPlayerFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		public const int TokenFieldNumber = 2;

		private bool hasToken;

		private string token_;

		public const int ThirdAccountFieldNumber = 3;

		private bool hasThirdAccount;

		private CCUserAccount thirdAccount_;

		public const int NameFieldNumber = 4;

		private bool hasName;

		private string name_;

		public const int FacebookIdFieldNumber = 31;

		private bool hasFacebookId;

		private string facebookId_;

		public const int HideFacebookPhotoFieldNumber = 53;

		private bool hasHideFacebookPhoto;

		private bool hideFacebookPhoto_;

		public const int CoinFieldNumber = 5;

		private bool hasCoin;

		private long coin_;

		public const int GemFieldNumber = 6;

		private bool hasGem;

		private long gem_;

		public const int ArenaLowCardFieldNumber = 7;

		private bool hasArenaLowCard;

		private int arenaLowCard_;

		public const int ArenaHighCardFieldNumber = 8;

		private bool hasArenaHighCard;

		private int arenaHighCard_;

		public const int PurTokenFieldNumber = 9;

		private bool hasPurToken;

		private string purToken_;

		public const int IsAdFreeFieldNumber = 10;

		private bool hasIsAdFree;

		private bool isAdFree_;

		public const int IsRobotFieldNumber = 11;

		private bool hasIsRobot;

		private bool isRobot_;

		public const int GetTrophyFieldNumber = 12;

		private bool hasGetTrophy;

		private long getTrophy_;

		public const int EquipDataFieldNumber = 13;

		private bool hasEquipData;

		private CCEquipData equipData_;

		public const int ClassicDataFieldNumber = 14;

		private bool hasClassicData;

		private CCClassicData classicData_;

		public const int RushDataFieldNumber = 15;

		private bool hasRushData;

		private CCRushData rushData_;

		public const int BingoDataFieldNumber = 16;

		private bool hasBingoData;

		private CCBingoData bingoData_;

		public const int ArenaDataFieldNumber = 17;

		private bool hasArenaData;

		private CCArenaData arenaData_;

		public const int ChallengeDataFieldNumber = 18;

		private bool hasChallengeData;

		private CCChallengeData challengeData_;

		public const int ChestClassicDataFieldNumber = 19;

		private bool hasChestClassicData;

		private CCChestClassicData chestClassicData_;

		public const int ShopDataFieldNumber = 20;

		private bool hasShopData;

		private CCShopData shopData_;

		public const int LeagueDataFieldNumber = 21;

		private bool hasLeagueData;

		private CCLeagueData leagueData_;

		public const int SingleDataFieldNumber = 22;

		private bool hasSingleData;

		private CCSingleData singleData_;

		public const int AchievementDataFieldNumber = 23;

		private bool hasAchievementData;

		private CCAchievementData achievementData_;

		public const int VideoFreeDataFieldNumber = 24;

		private bool hasVideoFreeData;

		private CCVideoFreeData videoFreeData_;

		public const int StatisticDataFieldNumber = 25;

		private bool hasStatisticData;

		private CCStatisticData statisticData_;

		public const int StateDataFieldNumber = 26;

		private bool hasStateData;

		private CCPlayerStateData stateData_;

		public const int FriendsDataFieldNumber = 27;

		private bool hasFriendsData;

		private CCPlayerFriendsData friendsData_;

		public const int SevenDailyBonusFieldNumber = 28;

		private bool hasSevenDailyBonus;

		private CCSevenDailyBonus sevenDailyBonus_;

		public const int GamblingRouletteFieldNumber = 29;

		private bool hasGamblingRoulette;

		private CCGamblingRoulette gamblingRoulette_;

		public const int LimitedTimeBuyFieldNumber = 30;

		private bool hasLimitedTimeBuy;

		private CCLimitedTimeBuy limitedTimeBuy_;

		public const int TutorialFinishedFieldNumber = 32;

		private bool hasTutorialFinished;

		private bool tutorialFinished_;

		public const int HasShownRateFieldNumber = 33;

		private bool hasHasShownRate;

		private bool hasShownRate_;

		public const int ContinueLoseGamesFieldNumber = 34;

		private bool hasContinueLoseGames;

		private int continueLoseGames_;

		public const int QuestDataFieldNumber = 35;

		private bool hasQuestData;

		private CCQuestData questData_;

		public const int MatchTimesFieldNumber = 36;

		private bool hasMatchTimes;

		private int matchTimes_;

		public const int GameModeStateFieldNumber = 37;

		private bool hasGameModeState;

		private CCPlayerGameModeState gameModeState_;

		public const int HasGetFbGiftFieldNumber = 38;

		private bool hasHasGetFbGift;

		private bool hasGetFbGift_;

		public const int LastUpgradeRewardIdFieldNumber = 39;

		private bool hasLastUpgradeRewardId;

		private int lastUpgradeRewardId_;

		public const int LastChangeNameMilFieldNumber = 40;

		private bool hasLastChangeNameMil;

		private long lastChangeNameMil_;

		public const int ActionStatsFieldNumber = 41;

		private bool hasActionStats;

		private CCPlayerActionStats actionStats_;

		public const int CurCliVersionFieldNumber = 42;

		private bool hasCurCliVersion;

		private string curCliVersion_;

		public const int LTBEquipTypeIdsFieldNumber = 43;

		private PopsicleList<int> lTBEquipTypeIds_;

		public const int LTBBuyedIdsFieldNumber = 44;

		private PopsicleList<int> lTBBuyedIds_;

		public const int PayScoreLeftFieldNumber = 45;

		private bool hasPayScoreLeft;

		private int payScoreLeft_;

		public const int BuyEquipScoreLeftFieldNumber = 46;

		private bool hasBuyEquipScoreLeft;

		private int buyEquipScoreLeft_;

		public const int UpgradeEquipScoreLeftFieldNumber = 47;

		private bool hasUpgradeEquipScoreLeft;

		private int upgradeEquipScoreLeft_;

		public const int UpCliVerFieldNumber = 48;

		private bool hasUpCliVer;

		private string upCliVer_;

		public const int LastMatchAiNamesFieldNumber = 49;

		private PopsicleList<string> lastMatchAiNames_;

		public const int ConWinChestFieldNumber = 50;

		private bool hasConWinChest;

		private CCPlayerConWinChest conWinChest_;

		public const int AbTestFieldNumber = 51;

		private bool hasAbTest;

		private int abTest_;

		public const int VideoFreeNewFieldNumber = 52;

		private bool hasVideoFreeNew;

		private CCVideoFreeNew videoFreeNew_;

		public const int ChestExtraFieldNumber = 54;

		private bool hasChestExtra;

		private CCChestExtra chestExtra_;

		private int memoizedSerializedSize;

		public static CCPlayer DefaultInstance => null;

		public override CCPlayer DefaultInstanceForType => null;

		protected override CCPlayer ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public bool HasToken => false;

		public string Token => null;

		public bool HasThirdAccount => false;

		public CCUserAccount ThirdAccount => null;

		public bool HasName => false;

		public string Name => null;

		public bool HasFacebookId => false;

		public string FacebookId => null;

		public bool HasHideFacebookPhoto => false;

		public bool HideFacebookPhoto => false;

		public bool HasCoin => false;

		public long Coin => 0L;

		public bool HasGem => false;

		public long Gem => 0L;

		public bool HasArenaLowCard => false;

		public int ArenaLowCard => 0;

		public bool HasArenaHighCard => false;

		public int ArenaHighCard => 0;

		public bool HasPurToken => false;

		public string PurToken => null;

		public bool HasIsAdFree => false;

		public bool IsAdFree => false;

		public bool HasIsRobot => false;

		public bool IsRobot => false;

		public bool HasGetTrophy => false;

		public long GetTrophy => 0L;

		public bool HasEquipData => false;

		public CCEquipData EquipData => null;

		public bool HasClassicData => false;

		public CCClassicData ClassicData => null;

		public bool HasRushData => false;

		public CCRushData RushData => null;

		public bool HasBingoData => false;

		public CCBingoData BingoData => null;

		public bool HasArenaData => false;

		public CCArenaData ArenaData => null;

		public bool HasChallengeData => false;

		public CCChallengeData ChallengeData => null;

		public bool HasChestClassicData => false;

		public CCChestClassicData ChestClassicData => null;

		public bool HasShopData => false;

		public CCShopData ShopData => null;

		public bool HasLeagueData => false;

		public CCLeagueData LeagueData => null;

		public bool HasSingleData => false;

		public CCSingleData SingleData => null;

		public bool HasAchievementData => false;

		public CCAchievementData AchievementData => null;

		public bool HasVideoFreeData => false;

		public CCVideoFreeData VideoFreeData => null;

		public bool HasStatisticData => false;

		public CCStatisticData StatisticData => null;

		public bool HasStateData => false;

		public CCPlayerStateData StateData => null;

		public bool HasFriendsData => false;

		public CCPlayerFriendsData FriendsData => null;

		public bool HasSevenDailyBonus => false;

		public CCSevenDailyBonus SevenDailyBonus => null;

		public bool HasGamblingRoulette => false;

		public CCGamblingRoulette GamblingRoulette => null;

		public bool HasLimitedTimeBuy => false;

		public CCLimitedTimeBuy LimitedTimeBuy => null;

		public bool HasTutorialFinished => false;

		public bool TutorialFinished => false;

		public bool HasHasShownRate => false;

		public bool HasShownRate => false;

		public bool HasContinueLoseGames => false;

		public int ContinueLoseGames => 0;

		public bool HasQuestData => false;

		public CCQuestData QuestData => null;

		public bool HasMatchTimes => false;

		public int MatchTimes => 0;

		public bool HasGameModeState => false;

		public CCPlayerGameModeState GameModeState => null;

		public bool HasHasGetFbGift => false;

		public bool HasGetFbGift => false;

		public bool HasLastUpgradeRewardId => false;

		public int LastUpgradeRewardId => 0;

		public bool HasLastChangeNameMil => false;

		public long LastChangeNameMil => 0L;

		public bool HasActionStats => false;

		public CCPlayerActionStats ActionStats => null;

		public bool HasCurCliVersion => false;

		public string CurCliVersion => null;

		public IList<int> LTBEquipTypeIdsList => null;

		public int LTBEquipTypeIdsCount => 0;

		public IList<int> LTBBuyedIdsList => null;

		public int LTBBuyedIdsCount => 0;

		public bool HasPayScoreLeft => false;

		public int PayScoreLeft => 0;

		public bool HasBuyEquipScoreLeft => false;

		public int BuyEquipScoreLeft => 0;

		public bool HasUpgradeEquipScoreLeft => false;

		public int UpgradeEquipScoreLeft => 0;

		public bool HasUpCliVer => false;

		public string UpCliVer => null;

		public IList<string> LastMatchAiNamesList => null;

		public int LastMatchAiNamesCount => 0;

		public bool HasConWinChest => false;

		public CCPlayerConWinChest ConWinChest => null;

		public bool HasAbTest => false;

		public int AbTest => 0;

		public bool HasVideoFreeNew => false;

		public CCVideoFreeNew VideoFreeNew => null;

		public bool HasChestExtra => false;

		public CCChestExtra ChestExtra => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayer()
		{
		}

		public int GetLTBEquipTypeIds(int index)
		{
			return 0;
		}

		public int GetLTBBuyedIds(int index)
		{
			return 0;
		}

		public string GetLastMatchAiNames(int index)
		{
			return null;
		}

		public override void WriteTo(ICodedOutputStream output)
		{
		}

		private int CalcSerializedSize()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override void PrintTo(TextWriter writer)
		{
		}

		public static CCPlayer ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayer ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayer ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayer ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayer ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayer ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayer ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayer ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayer ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayer ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayer MakeReadOnly()
		{
			return null;
		}

		public static Builder CreateBuilder()
		{
			return null;
		}

		public override Builder ToBuilder()
		{
			return null;
		}

		public override Builder CreateBuilderForType()
		{
			return null;
		}

		public static Builder CreateBuilder(CCPlayer prototype)
		{
			return null;
		}

		static CCPlayer()
		{
		}
	}
}
