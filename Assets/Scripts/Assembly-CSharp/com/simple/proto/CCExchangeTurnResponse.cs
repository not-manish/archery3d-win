using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCExchangeTurnResponse : GeneratedMessageLite<CCExchangeTurnResponse, CCExchangeTurnResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCExchangeTurnResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCExchangeTurnResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCExchangeTurnResponse MessageBeingBuilt => null;

			public override CCExchangeTurnResponse DefaultInstanceForType => null;

			public bool HasStatus => false;

			public CCStatus Status
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasIsTurn => false;

			public bool IsTurn
			{
				get
				{
					return false;
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

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

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

			public Builder()
			{
			}

			internal Builder(CCExchangeTurnResponse cloneFrom)
			{
			}

			private CCExchangeTurnResponse PrepareBuilder()
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

			public override CCExchangeTurnResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCExchangeTurnResponse other)
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

			public Builder SetStatus(CCStatus value)
			{
				return null;
			}

			public Builder SetStatus(CCStatus.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStatus(CCStatus value)
			{
				return null;
			}

			public Builder ClearStatus()
			{
				return null;
			}

			public Builder SetIsTurn(bool value)
			{
				return null;
			}

			public Builder ClearIsTurn()
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

			public Builder SetNextRound(int value)
			{
				return null;
			}

			public Builder ClearNextRound()
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
		}

		private static readonly CCExchangeTurnResponse defaultInstance;

		private static readonly string[] _cCExchangeTurnResponseFieldNames;

		private static readonly uint[] _cCExchangeTurnResponseFieldTags;

		public const int StatusFieldNumber = 1;

		private bool hasStatus;

		private CCStatus status_;

		public const int IsTurnFieldNumber = 2;

		private bool hasIsTurn;

		private bool isTurn_;

		public const int RoundDataFieldNumber = 3;

		private bool hasRoundData;

		private CCRoundData roundData_;

		public const int GameTypeFieldNumber = 4;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 5;

		private bool hasPvpType;

		private int pvpType_;

		public const int NextRoundFieldNumber = 6;

		private bool hasNextRound;

		private int nextRound_;

		public const int ScoreMyFieldNumber = 7;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 8;

		private PopsicleList<int> scoreOpp_;

		public const int AiNextRountFieldNumber = 9;

		private bool hasAiNextRount;

		private int aiNextRount_;

		public const int AiNextScoreFieldNumber = 10;

		private bool hasAiNextScore;

		private int aiNextScore_;

		public const int IdToScoresMyFieldNumber = 11;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 12;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		private int memoizedSerializedSize;

		public static CCExchangeTurnResponse DefaultInstance => null;

		public override CCExchangeTurnResponse DefaultInstanceForType => null;

		protected override CCExchangeTurnResponse ThisMessage => null;

		public bool HasStatus => false;

		public CCStatus Status => null;

		public bool HasIsTurn => false;

		public bool IsTurn => false;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasNextRound => false;

		public int NextRound => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public bool HasAiNextRount => false;

		public int AiNextRount => 0;

		public bool HasAiNextScore => false;

		public int AiNextScore => 0;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCExchangeTurnResponse()
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

		public static CCExchangeTurnResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCExchangeTurnResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCExchangeTurnResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCExchangeTurnResponse prototype)
		{
			return null;
		}

		static CCExchangeTurnResponse()
		{
		}
	}
}
