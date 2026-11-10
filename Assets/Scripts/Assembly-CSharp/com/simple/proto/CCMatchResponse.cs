using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCMatchResponse : GeneratedMessageLite<CCMatchResponse, CCMatchResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCMatchResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCMatchResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCMatchResponse MessageBeingBuilt => null;

			public override CCMatchResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
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

			public bool HasLevelIndex => false;

			public int LevelIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOpponentInfo => false;

			public CCPlayer OpponentInfo
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasIsFirst => false;

			public bool IsFirst
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasIsStandLeft => false;

			public bool IsStandLeft
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasNextRound => false;

			public int NextRound
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRoundData => false;

			public CCRoundData RoundData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public bool HasIsNewGame => false;

			public bool IsNewGame
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasShareTargets => false;

			public bool ShareTargets
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public IPopsicleList<int> MyTargetIdsList => null;

			public int MyTargetIdsCount => 0;

			public IPopsicleList<int> OppTargetIdsList => null;

			public int OppTargetIdsCount => 0;

			public bool HasTargetRangeId => false;

			public int TargetRangeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> BingoMy5X5List => null;

			public int BingoMy5X5Count => 0;

			public IPopsicleList<int> BingoOpp5X5List => null;

			public int BingoOpp5X5Count => 0;

			public bool HasTargetMoveTime => false;

			public int TargetMoveTime
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCShootItem> RobotShootItemsList => null;

			public int RobotShootItemsCount => 0;

			public bool HasAiNextRount => false;

			public int AiNextRount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAiNextScore => false;

			public int AiNextScore
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

			public bool HasAiRushShootTimes => false;

			public int AiRushShootTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCMatchResponse cloneFrom)
			{
			}

			private CCMatchResponse PrepareBuilder()
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

			public override CCMatchResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCMatchResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
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

			public Builder SetLevelIndex(int value)
			{
				return null;
			}

			public Builder ClearLevelIndex()
			{
				return null;
			}

			public Builder SetOpponentInfo(CCPlayer value)
			{
				return null;
			}

			public Builder SetOpponentInfo(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeOpponentInfo(CCPlayer value)
			{
				return null;
			}

			public Builder ClearOpponentInfo()
			{
				return null;
			}

			public Builder SetIsFirst(bool value)
			{
				return null;
			}

			public Builder ClearIsFirst()
			{
				return null;
			}

			public Builder SetIsStandLeft(bool value)
			{
				return null;
			}

			public Builder ClearIsStandLeft()
			{
				return null;
			}

			public Builder SetNextRound(int value)
			{
				return null;
			}

			public Builder ClearNextRound()
			{
				return null;
			}

			public Builder SetRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder SetRoundData(CCRoundData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder ClearRoundData()
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

			public Builder SetIsNewGame(bool value)
			{
				return null;
			}

			public Builder ClearIsNewGame()
			{
				return null;
			}

			public Builder SetShareTargets(bool value)
			{
				return null;
			}

			public Builder ClearShareTargets()
			{
				return null;
			}

			public int GetMyTargetIds(int index)
			{
				return 0;
			}

			public Builder SetMyTargetIds(int index, int value)
			{
				return null;
			}

			public Builder AddMyTargetIds(int value)
			{
				return null;
			}

			public Builder AddRangeMyTargetIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearMyTargetIds()
			{
				return null;
			}

			public int GetOppTargetIds(int index)
			{
				return 0;
			}

			public Builder SetOppTargetIds(int index, int value)
			{
				return null;
			}

			public Builder AddOppTargetIds(int value)
			{
				return null;
			}

			public Builder AddRangeOppTargetIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearOppTargetIds()
			{
				return null;
			}

			public Builder SetTargetRangeId(int value)
			{
				return null;
			}

			public Builder ClearTargetRangeId()
			{
				return null;
			}

			public int GetBingoMy5X5(int index)
			{
				return 0;
			}

			public Builder SetBingoMy5X5(int index, int value)
			{
				return null;
			}

			public Builder AddBingoMy5X5(int value)
			{
				return null;
			}

			public Builder AddRangeBingoMy5X5(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearBingoMy5X5()
			{
				return null;
			}

			public int GetBingoOpp5X5(int index)
			{
				return 0;
			}

			public Builder SetBingoOpp5X5(int index, int value)
			{
				return null;
			}

			public Builder AddBingoOpp5X5(int value)
			{
				return null;
			}

			public Builder AddRangeBingoOpp5X5(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearBingoOpp5X5()
			{
				return null;
			}

			public Builder SetTargetMoveTime(int value)
			{
				return null;
			}

			public Builder ClearTargetMoveTime()
			{
				return null;
			}

			public CCShootItem GetRobotShootItems(int index)
			{
				return null;
			}

			public Builder SetRobotShootItems(int index, CCShootItem value)
			{
				return null;
			}

			public Builder SetRobotShootItems(int index, CCShootItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRobotShootItems(CCShootItem value)
			{
				return null;
			}

			public Builder AddRobotShootItems(CCShootItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeRobotShootItems(IEnumerable<CCShootItem> values)
			{
				return null;
			}

			public Builder ClearRobotShootItems()
			{
				return null;
			}

			public Builder SetAiNextRount(int value)
			{
				return null;
			}

			public Builder ClearAiNextRount()
			{
				return null;
			}

			public Builder SetAiNextScore(int value)
			{
				return null;
			}

			public Builder ClearAiNextScore()
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

			public Builder SetAiRushShootTimes(int value)
			{
				return null;
			}

			public Builder ClearAiRushShootTimes()
			{
				return null;
			}
		}

		private static readonly CCMatchResponse defaultInstance;

		private static readonly string[] _cCMatchResponseFieldNames;

		private static readonly uint[] _cCMatchResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int MatchTypeFieldNumber = 3;

		private bool hasMatchType;

		private int matchType_;

		public const int GameTypeFieldNumber = 4;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 5;

		private bool hasPvpType;

		private int pvpType_;

		public const int LevelIdFieldNumber = 6;

		private bool hasLevelId;

		private int levelId_;

		public const int LevelIndexFieldNumber = 7;

		private bool hasLevelIndex;

		private int levelIndex_;

		public const int OpponentInfoFieldNumber = 8;

		private bool hasOpponentInfo;

		private CCPlayer opponentInfo_;

		public const int IsFirstFieldNumber = 9;

		private bool hasIsFirst;

		private bool isFirst_;

		public const int IsStandLeftFieldNumber = 10;

		private bool hasIsStandLeft;

		private bool isStandLeft_;

		public const int NextRoundFieldNumber = 11;

		private bool hasNextRound;

		private int nextRound_;

		public const int RoundDataFieldNumber = 12;

		private bool hasRoundData;

		private CCRoundData roundData_;

		public const int ScoreMyFieldNumber = 13;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 14;

		private PopsicleList<int> scoreOpp_;

		public const int IsNewGameFieldNumber = 15;

		private bool hasIsNewGame;

		private bool isNewGame_;

		public const int ShareTargetsFieldNumber = 16;

		private bool hasShareTargets;

		private bool shareTargets_;

		public const int MyTargetIdsFieldNumber = 17;

		private PopsicleList<int> myTargetIds_;

		public const int OppTargetIdsFieldNumber = 18;

		private PopsicleList<int> oppTargetIds_;

		public const int TargetRangeIdFieldNumber = 19;

		private bool hasTargetRangeId;

		private int targetRangeId_;

		public const int BingoMy5X5FieldNumber = 20;

		private PopsicleList<int> bingoMy5X5_;

		public const int BingoOpp5X5FieldNumber = 21;

		private PopsicleList<int> bingoOpp5X5_;

		public const int TargetMoveTimeFieldNumber = 22;

		private bool hasTargetMoveTime;

		private int targetMoveTime_;

		public const int RobotShootItemsFieldNumber = 23;

		private PopsicleList<CCShootItem> robotShootItems_;

		public const int AiNextRountFieldNumber = 24;

		private bool hasAiNextRount;

		private int aiNextRount_;

		public const int AiNextScoreFieldNumber = 25;

		private bool hasAiNextScore;

		private int aiNextScore_;

		public const int IdToScoresMyFieldNumber = 26;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 27;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		public const int AiRushShootTimesFieldNumber = 28;

		private bool hasAiRushShootTimes;

		private int aiRushShootTimes_;

		private int memoizedSerializedSize;

		public static CCMatchResponse DefaultInstance => null;

		public override CCMatchResponse DefaultInstanceForType => null;

		protected override CCMatchResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasMatchType => false;

		public int MatchType => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasLevelIndex => false;

		public int LevelIndex => 0;

		public bool HasOpponentInfo => false;

		public CCPlayer OpponentInfo => null;

		public bool HasIsFirst => false;

		public bool IsFirst => false;

		public bool HasIsStandLeft => false;

		public bool IsStandLeft => false;

		public bool HasNextRound => false;

		public int NextRound => 0;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public bool HasIsNewGame => false;

		public bool IsNewGame => false;

		public bool HasShareTargets => false;

		public bool ShareTargets => false;

		public IList<int> MyTargetIdsList => null;

		public int MyTargetIdsCount => 0;

		public IList<int> OppTargetIdsList => null;

		public int OppTargetIdsCount => 0;

		public bool HasTargetRangeId => false;

		public int TargetRangeId => 0;

		public IList<int> BingoMy5X5List => null;

		public int BingoMy5X5Count => 0;

		public IList<int> BingoOpp5X5List => null;

		public int BingoOpp5X5Count => 0;

		public bool HasTargetMoveTime => false;

		public int TargetMoveTime => 0;

		public IList<CCShootItem> RobotShootItemsList => null;

		public int RobotShootItemsCount => 0;

		public bool HasAiNextRount => false;

		public int AiNextRount => 0;

		public bool HasAiNextScore => false;

		public int AiNextScore => 0;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public bool HasAiRushShootTimes => false;

		public int AiRushShootTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCMatchResponse()
		{
		}

		public int GetScoreMy(int index)
		{
			return 0;
		}

		public int GetScoreOpp(int index)
		{
			return 0;
		}

		public int GetMyTargetIds(int index)
		{
			return 0;
		}

		public int GetOppTargetIds(int index)
		{
			return 0;
		}

		public int GetBingoMy5X5(int index)
		{
			return 0;
		}

		public int GetBingoOpp5X5(int index)
		{
			return 0;
		}

		public CCShootItem GetRobotShootItems(int index)
		{
			return null;
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

		public static CCMatchResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCMatchResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCMatchResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCMatchResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCMatchResponse prototype)
		{
			return null;
		}

		static CCMatchResponse()
		{
		}
	}
}
