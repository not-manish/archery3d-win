using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponse : GeneratedMessageLite<CCGamePlayingStatesResponse, CCGamePlayingStatesResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponse MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponse DefaultInstanceForType => null;

			public bool HasIsPlaying => false;

			public bool IsPlaying
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasGameState => false;

			public int GameState
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

			public bool HasIsMyFirst => false;

			public bool IsMyFirst
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasTimeLeftSeconds => false;

			public float TimeLeftSeconds
			{
				get
				{
					return 0f;
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

			public bool HasDataPanDian => false;

			public CCGamePlayingStatesResponsePanDian DataPanDian
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasDataHuiHe => false;

			public CCGamePlayingStatesResponseHuiHe DataHuiHe
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasDataChongCi => false;

			public CCGamePlayingStatesResponseChongCi DataChongCi
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasDataBingo => false;

			public CCGamePlayingStatesResponseBingo DataBingo
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasDataSingle => false;

			public CCGamePlayingStatesResponseSingle DataSingle
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

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

			public bool HasGameOverResponse => false;

			public CCGameOverResponse GameOverResponse
			{
				get
				{
					return null;
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

			internal Builder(CCGamePlayingStatesResponse cloneFrom)
			{
			}

			private CCGamePlayingStatesResponse PrepareBuilder()
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

			public override CCGamePlayingStatesResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponse other)
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

			public Builder SetIsPlaying(bool value)
			{
				return null;
			}

			public Builder ClearIsPlaying()
			{
				return null;
			}

			public Builder SetGameState(int value)
			{
				return null;
			}

			public Builder ClearGameState()
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

			public Builder SetIsStandLeft(bool value)
			{
				return null;
			}

			public Builder ClearIsStandLeft()
			{
				return null;
			}

			public Builder SetIsMyFirst(bool value)
			{
				return null;
			}

			public Builder ClearIsMyFirst()
			{
				return null;
			}

			public Builder SetTimeLeftSeconds(float value)
			{
				return null;
			}

			public Builder ClearTimeLeftSeconds()
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

			public Builder SetDataPanDian(CCGamePlayingStatesResponsePanDian value)
			{
				return null;
			}

			public Builder SetDataPanDian(CCGamePlayingStatesResponsePanDian.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeDataPanDian(CCGamePlayingStatesResponsePanDian value)
			{
				return null;
			}

			public Builder ClearDataPanDian()
			{
				return null;
			}

			public Builder SetDataHuiHe(CCGamePlayingStatesResponseHuiHe value)
			{
				return null;
			}

			public Builder SetDataHuiHe(CCGamePlayingStatesResponseHuiHe.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeDataHuiHe(CCGamePlayingStatesResponseHuiHe value)
			{
				return null;
			}

			public Builder ClearDataHuiHe()
			{
				return null;
			}

			public Builder SetDataChongCi(CCGamePlayingStatesResponseChongCi value)
			{
				return null;
			}

			public Builder SetDataChongCi(CCGamePlayingStatesResponseChongCi.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeDataChongCi(CCGamePlayingStatesResponseChongCi value)
			{
				return null;
			}

			public Builder ClearDataChongCi()
			{
				return null;
			}

			public Builder SetDataBingo(CCGamePlayingStatesResponseBingo value)
			{
				return null;
			}

			public Builder SetDataBingo(CCGamePlayingStatesResponseBingo.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeDataBingo(CCGamePlayingStatesResponseBingo value)
			{
				return null;
			}

			public Builder ClearDataBingo()
			{
				return null;
			}

			public Builder SetDataSingle(CCGamePlayingStatesResponseSingle value)
			{
				return null;
			}

			public Builder SetDataSingle(CCGamePlayingStatesResponseSingle.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeDataSingle(CCGamePlayingStatesResponseSingle value)
			{
				return null;
			}

			public Builder ClearDataSingle()
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

			public Builder SetGameOverResponse(CCGameOverResponse value)
			{
				return null;
			}

			public Builder SetGameOverResponse(CCGameOverResponse.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeGameOverResponse(CCGameOverResponse value)
			{
				return null;
			}

			public Builder ClearGameOverResponse()
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

		private static readonly CCGamePlayingStatesResponse defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponseFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponseFieldTags;

		public const int IsPlayingFieldNumber = 1;

		private bool hasIsPlaying;

		private bool isPlaying_;

		public const int GameStateFieldNumber = 2;

		private bool hasGameState;

		private int gameState_;

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

		public const int LevelIndexFieldNumber = 23;

		private bool hasLevelIndex;

		private int levelIndex_;

		public const int IsStandLeftFieldNumber = 7;

		private bool hasIsStandLeft;

		private bool isStandLeft_;

		public const int IsMyFirstFieldNumber = 8;

		private bool hasIsMyFirst;

		private bool isMyFirst_;

		public const int TimeLeftSecondsFieldNumber = 9;

		private bool hasTimeLeftSeconds;

		private float timeLeftSeconds_;

		public const int RoundDataFieldNumber = 10;

		private bool hasRoundData;

		private CCRoundData roundData_;

		public const int OpponentInfoFieldNumber = 11;

		private bool hasOpponentInfo;

		private CCPlayer opponentInfo_;

		public const int ShareTargetsFieldNumber = 12;

		private bool hasShareTargets;

		private bool shareTargets_;

		public const int MyTargetIdsFieldNumber = 13;

		private PopsicleList<int> myTargetIds_;

		public const int OppTargetIdsFieldNumber = 14;

		private PopsicleList<int> oppTargetIds_;

		public const int TargetRangeIdFieldNumber = 15;

		private bool hasTargetRangeId;

		private int targetRangeId_;

		public const int TargetMoveTimeFieldNumber = 16;

		private bool hasTargetMoveTime;

		private int targetMoveTime_;

		public const int RobotShootItemsFieldNumber = 17;

		private PopsicleList<CCShootItem> robotShootItems_;

		public const int DataPanDianFieldNumber = 18;

		private bool hasDataPanDian;

		private CCGamePlayingStatesResponsePanDian dataPanDian_;

		public const int DataHuiHeFieldNumber = 19;

		private bool hasDataHuiHe;

		private CCGamePlayingStatesResponseHuiHe dataHuiHe_;

		public const int DataChongCiFieldNumber = 20;

		private bool hasDataChongCi;

		private CCGamePlayingStatesResponseChongCi dataChongCi_;

		public const int DataBingoFieldNumber = 21;

		private bool hasDataBingo;

		private CCGamePlayingStatesResponseBingo dataBingo_;

		public const int DataSingleFieldNumber = 22;

		private bool hasDataSingle;

		private CCGamePlayingStatesResponseSingle dataSingle_;

		public const int AiNextRountFieldNumber = 24;

		private bool hasAiNextRount;

		private int aiNextRount_;

		public const int AiNextScoreFieldNumber = 25;

		private bool hasAiNextScore;

		private int aiNextScore_;

		public const int GameOverResponseFieldNumber = 26;

		private bool hasGameOverResponse;

		private CCGameOverResponse gameOverResponse_;

		public const int IdToScoresMyFieldNumber = 27;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 28;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		public const int AiRushShootTimesFieldNumber = 29;

		private bool hasAiRushShootTimes;

		private int aiRushShootTimes_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponse DefaultInstance => null;

		public override CCGamePlayingStatesResponse DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponse ThisMessage => null;

		public bool HasIsPlaying => false;

		public bool IsPlaying => false;

		public bool HasGameState => false;

		public int GameState => 0;

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

		public bool HasIsStandLeft => false;

		public bool IsStandLeft => false;

		public bool HasIsMyFirst => false;

		public bool IsMyFirst => false;

		public bool HasTimeLeftSeconds => false;

		public float TimeLeftSeconds => 0f;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public bool HasOpponentInfo => false;

		public CCPlayer OpponentInfo => null;

		public bool HasShareTargets => false;

		public bool ShareTargets => false;

		public IList<int> MyTargetIdsList => null;

		public int MyTargetIdsCount => 0;

		public IList<int> OppTargetIdsList => null;

		public int OppTargetIdsCount => 0;

		public bool HasTargetRangeId => false;

		public int TargetRangeId => 0;

		public bool HasTargetMoveTime => false;

		public int TargetMoveTime => 0;

		public IList<CCShootItem> RobotShootItemsList => null;

		public int RobotShootItemsCount => 0;

		public bool HasDataPanDian => false;

		public CCGamePlayingStatesResponsePanDian DataPanDian => null;

		public bool HasDataHuiHe => false;

		public CCGamePlayingStatesResponseHuiHe DataHuiHe => null;

		public bool HasDataChongCi => false;

		public CCGamePlayingStatesResponseChongCi DataChongCi => null;

		public bool HasDataBingo => false;

		public CCGamePlayingStatesResponseBingo DataBingo => null;

		public bool HasDataSingle => false;

		public CCGamePlayingStatesResponseSingle DataSingle => null;

		public bool HasAiNextRount => false;

		public int AiNextRount => 0;

		public bool HasAiNextScore => false;

		public int AiNextScore => 0;

		public bool HasGameOverResponse => false;

		public CCGameOverResponse GameOverResponse => null;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public bool HasAiRushShootTimes => false;

		public int AiRushShootTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponse()
		{
		}

		public int GetMyTargetIds(int index)
		{
			return 0;
		}

		public int GetOppTargetIds(int index)
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

		public static CCGamePlayingStatesResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponse prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponse()
		{
		}
	}
}
