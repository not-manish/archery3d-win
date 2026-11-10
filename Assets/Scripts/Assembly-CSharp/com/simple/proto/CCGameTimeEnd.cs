using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGameTimeEnd : GeneratedMessageLite<CCGameTimeEnd, CCGameTimeEnd.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGameTimeEnd, Builder>
		{
			private bool resultIsReadOnly;

			private CCGameTimeEnd result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGameTimeEnd MessageBeingBuilt => null;

			public override CCGameTimeEnd DefaultInstanceForType => null;

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

			public IPopsicleList<int> RoundCountMyList => null;

			public int RoundCountMyCount => 0;

			public IPopsicleList<int> RoundCountOppList => null;

			public int RoundCountOppCount => 0;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresMyList => null;

			public int IdToScoresMyCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresOppList => null;

			public int IdToScoresOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGameTimeEnd cloneFrom)
			{
			}

			private CCGameTimeEnd PrepareBuilder()
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

			public override CCGameTimeEnd BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGameTimeEnd other)
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

			public Builder SetGameResult(int value)
			{
				return null;
			}

			public Builder ClearGameResult()
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

		private static readonly CCGameTimeEnd defaultInstance;

		private static readonly string[] _cCGameTimeEndFieldNames;

		private static readonly uint[] _cCGameTimeEndFieldTags;

		public const int GameTypeFieldNumber = 1;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 2;

		private bool hasPvpType;

		private int pvpType_;

		public const int GameResultFieldNumber = 3;

		private bool hasGameResult;

		private int gameResult_;

		public const int RoundCountMyFieldNumber = 4;

		private PopsicleList<int> roundCountMy_;

		public const int RoundCountOppFieldNumber = 5;

		private PopsicleList<int> roundCountOpp_;

		public const int ScoreMyFieldNumber = 6;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 7;

		private PopsicleList<int> scoreOpp_;

		public const int IdToScoresMyFieldNumber = 8;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 9;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		private int memoizedSerializedSize;

		public static CCGameTimeEnd DefaultInstance => null;

		public override CCGameTimeEnd DefaultInstanceForType => null;

		protected override CCGameTimeEnd ThisMessage => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasGameResult => false;

		public int GameResult => 0;

		public IList<int> RoundCountMyList => null;

		public int RoundCountMyCount => 0;

		public IList<int> RoundCountOppList => null;

		public int RoundCountOppCount => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGameTimeEnd()
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

		public static CCGameTimeEnd ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeEnd ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGameTimeEnd ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGameTimeEnd ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGameTimeEnd MakeReadOnly()
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

		public static Builder CreateBuilder(CCGameTimeEnd prototype)
		{
			return null;
		}

		static CCGameTimeEnd()
		{
		}
	}
}
