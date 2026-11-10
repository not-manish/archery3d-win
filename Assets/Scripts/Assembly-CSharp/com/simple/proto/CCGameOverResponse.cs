using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGameOverResponse : GeneratedMessageLite<CCGameOverResponse, CCGameOverResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGameOverResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGameOverResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGameOverResponse MessageBeingBuilt => null;

			public override CCGameOverResponse DefaultInstanceForType => null;

			public bool HasGameResult => false;

			public int GameResult
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasMatchType => false;

			public int MatchType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGameType => false;

			public int GameType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPvpType => false;

			public int PvpType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevelId => false;

			public int LevelId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIsGiveup => false;

			public bool IsGiveup
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasGameTimeCost => false;

			public int GameTimeCost
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> RoundCountMyList => null;

			public int RoundCountMyCount => 0;

			public IPopsicleList<int> RoundCountOppList => null;

			public int RoundCountOppCount => 0;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public bool HasCoinRewardSum => false;

			public int CoinRewardSum
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCoinRewardMy => false;

			public int CoinRewardMy
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCoinRewardOpp => false;

			public int CoinRewardOpp
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTrophyBeforeMy => false;

			public int TrophyBeforeMy
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTrophyBeforeOpp => false;

			public int TrophyBeforeOpp
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTrophyRewardMy => false;

			public int TrophyRewardMy
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTrophyRewardOpp => false;

			public int TrophyRewardOpp
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHasChest => false;

			public bool HasChest
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasChestKind => false;

			public int ChestKind
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestId => false;

			public int ChestId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCKeyValueIntInt> IdToScoresMyList => null;

			public int IdToScoresMyCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresOppList => null;

			public int IdToScoresOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGameOverResponse cloneFrom)
			{
			}

			private CCGameOverResponse PrepareBuilder()
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

			public override CCGameOverResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGameOverResponse other)
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

			public Builder SetGameResult(int value)
			{
				return null;
			}

			public Builder ClearGameResult()
			{
				return null;
			}

			public Builder SetMatchType(int value)
			{
				return null;
			}

			public Builder ClearMatchType()
			{
				return null;
			}

			public Builder SetGameType(int value)
			{
				return null;
			}

			public Builder ClearGameType()
			{
				return null;
			}

			public Builder SetPvpType(int value)
			{
				return null;
			}

			public Builder ClearPvpType()
			{
				return null;
			}

			public Builder SetLevelId(int value)
			{
				return null;
			}

			public Builder ClearLevelId()
			{
				return null;
			}

			public Builder SetIsGiveup(bool value)
			{
				return null;
			}

			public Builder ClearIsGiveup()
			{
				return null;
			}

			public Builder SetGameTimeCost(int value)
			{
				return null;
			}

			public Builder ClearGameTimeCost()
			{
				return null;
			}

			public int GetRoundCountMy(int index)
			{
				return 0;
			}

			public Builder SetRoundCountMy(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountMy(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountMy()
			{
				return null;
			}

			public int GetRoundCountOpp(int index)
			{
				return 0;
			}

			public Builder SetRoundCountOpp(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountOpp(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountOpp()
			{
				return null;
			}

			public int GetScoreMy(int index)
			{
				return 0;
			}

			public Builder SetScoreMy(int index, int value)
			{
				return null;
			}

			public Builder AddScoreMy(int value)
			{
				return null;
			}

			public Builder AddRangeScoreMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreMy()
			{
				return null;
			}

			public int GetScoreOpp(int index)
			{
				return 0;
			}

			public Builder SetScoreOpp(int index, int value)
			{
				return null;
			}

			public Builder AddScoreOpp(int value)
			{
				return null;
			}

			public Builder AddRangeScoreOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreOpp()
			{
				return null;
			}

			public Builder SetCoinRewardSum(int value)
			{
				return null;
			}

			public Builder ClearCoinRewardSum()
			{
				return null;
			}

			public Builder SetCoinRewardMy(int value)
			{
				return null;
			}

			public Builder ClearCoinRewardMy()
			{
				return null;
			}

			public Builder SetCoinRewardOpp(int value)
			{
				return null;
			}

			public Builder ClearCoinRewardOpp()
			{
				return null;
			}

			public Builder SetTrophyBeforeMy(int value)
			{
				return null;
			}

			public Builder ClearTrophyBeforeMy()
			{
				return null;
			}

			public Builder SetTrophyBeforeOpp(int value)
			{
				return null;
			}

			public Builder ClearTrophyBeforeOpp()
			{
				return null;
			}

			public Builder SetTrophyRewardMy(int value)
			{
				return null;
			}

			public Builder ClearTrophyRewardMy()
			{
				return null;
			}

			public Builder SetTrophyRewardOpp(int value)
			{
				return null;
			}

			public Builder ClearTrophyRewardOpp()
			{
				return null;
			}

			public Builder SetHasChest(bool value)
			{
				return null;
			}

			public Builder ClearHasChest()
			{
				return null;
			}

			public Builder SetChestKind(int value)
			{
				return null;
			}

			public Builder ClearChestKind()
			{
				return null;
			}

			public Builder SetChestId(int value)
			{
				return null;
			}

			public Builder ClearChestId()
			{
				return null;
			}

			public CCKeyValueIntInt GetIdToScoresMy(int index)
			{
				return null;
			}

			public Builder SetIdToScoresMy(int index, CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder SetIdToScoresMy(int index, CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddIdToScoresMy(CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder AddIdToScoresMy(CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeIdToScoresMy(IEnumerable<CCKeyValueIntInt> values)
			{
				return null;
			}

			public Builder ClearIdToScoresMy()
			{
				return null;
			}

			public CCKeyValueIntInt GetIdToScoresOpp(int index)
			{
				return null;
			}

			public Builder SetIdToScoresOpp(int index, CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder SetIdToScoresOpp(int index, CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddIdToScoresOpp(CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder AddIdToScoresOpp(CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeIdToScoresOpp(IEnumerable<CCKeyValueIntInt> values)
			{
				return null;
			}

			public Builder ClearIdToScoresOpp()
			{
				return null;
			}
		}

		private static readonly CCGameOverResponse defaultInstance;

		private static readonly string[] _cCGameOverResponseFieldNames;

		private static readonly uint[] _cCGameOverResponseFieldTags;

		public const int GameResultFieldNumber = 1;

		private bool hasGameResult;

		private int gameResult_;

		public const int MatchTypeFieldNumber = 2;

		private bool hasMatchType;

		private int matchType_;

		public const int GameTypeFieldNumber = 3;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 4;

		private bool hasPvpType;

		private int pvpType_;

		public const int LevelIdFieldNumber = 5;

		private bool hasLevelId;

		private int levelId_;

		public const int IsGiveupFieldNumber = 6;

		private bool hasIsGiveup;

		private bool isGiveup_;

		public const int GameTimeCostFieldNumber = 7;

		private bool hasGameTimeCost;

		private int gameTimeCost_;

		public const int RoundCountMyFieldNumber = 8;

		private PopsicleList<int> roundCountMy_;

		public const int RoundCountOppFieldNumber = 9;

		private PopsicleList<int> roundCountOpp_;

		public const int ScoreMyFieldNumber = 10;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 11;

		private PopsicleList<int> scoreOpp_;

		public const int CoinRewardSumFieldNumber = 12;

		private bool hasCoinRewardSum;

		private int coinRewardSum_;

		public const int CoinRewardMyFieldNumber = 13;

		private bool hasCoinRewardMy;

		private int coinRewardMy_;

		public const int CoinRewardOppFieldNumber = 14;

		private bool hasCoinRewardOpp;

		private int coinRewardOpp_;

		public const int TrophyBeforeMyFieldNumber = 15;

		private bool hasTrophyBeforeMy;

		private int trophyBeforeMy_;

		public const int TrophyBeforeOppFieldNumber = 16;

		private bool hasTrophyBeforeOpp;

		private int trophyBeforeOpp_;

		public const int TrophyRewardMyFieldNumber = 17;

		private bool hasTrophyRewardMy;

		private int trophyRewardMy_;

		public const int TrophyRewardOppFieldNumber = 18;

		private bool hasTrophyRewardOpp;

		private int trophyRewardOpp_;

		public const int HasChestFieldNumber = 19;

		private bool hasHasChest;

		private bool hasChest_;

		public const int ChestKindFieldNumber = 20;

		private bool hasChestKind;

		private int chestKind_;

		public const int ChestIdFieldNumber = 21;

		private bool hasChestId;

		private int chestId_;

		public const int IdToScoresMyFieldNumber = 22;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 23;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		private int memoizedSerializedSize;

		public static CCGameOverResponse DefaultInstance => null;

		public override CCGameOverResponse DefaultInstanceForType => null;

		protected override CCGameOverResponse ThisMessage => null;

		public bool HasGameResult => false;

		public int GameResult => 0;

		public bool HasMatchType => false;

		public int MatchType => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasIsGiveup => false;

		public bool IsGiveup => false;

		public bool HasGameTimeCost => false;

		public int GameTimeCost => 0;

		public IList<int> RoundCountMyList => null;

		public int RoundCountMyCount => 0;

		public IList<int> RoundCountOppList => null;

		public int RoundCountOppCount => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public bool HasCoinRewardSum => false;

		public int CoinRewardSum => 0;

		public bool HasCoinRewardMy => false;

		public int CoinRewardMy => 0;

		public bool HasCoinRewardOpp => false;

		public int CoinRewardOpp => 0;

		public bool HasTrophyBeforeMy => false;

		public int TrophyBeforeMy => 0;

		public bool HasTrophyBeforeOpp => false;

		public int TrophyBeforeOpp => 0;

		public bool HasTrophyRewardMy => false;

		public int TrophyRewardMy => 0;

		public bool HasTrophyRewardOpp => false;

		public int TrophyRewardOpp => 0;

		public bool HasHasChest => false;

		public bool HasChest => false;

		public bool HasChestKind => false;

		public int ChestKind => 0;

		public bool HasChestId => false;

		public int ChestId => 0;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGameOverResponse()
		{
		}

		public int GetRoundCountMy(int index)
		{
			return 0;
		}

		public int GetRoundCountOpp(int index)
		{
			return 0;
		}

		public int GetScoreMy(int index)
		{
			return 0;
		}

		public int GetScoreOpp(int index)
		{
			return 0;
		}

		public CCKeyValueIntInt GetIdToScoresMy(int index)
		{
			return null;
		}

		public CCKeyValueIntInt GetIdToScoresOpp(int index)
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

		public static CCGameOverResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameOverResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGameOverResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGameOverResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGameOverResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGameOverResponse prototype)
		{
			return null;
		}

		static CCGameOverResponse()
		{
		}
	}
}
