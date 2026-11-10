using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGameTimeBegin : GeneratedMessageLite<CCGameTimeBegin, CCGameTimeBegin.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGameTimeBegin, Builder>
		{
			private bool resultIsReadOnly;

			private CCGameTimeBegin result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGameTimeBegin MessageBeingBuilt => null;

			public override CCGameTimeBegin DefaultInstanceForType => null;

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

			public bool HasGameTime => false;

			public int GameTime
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

			public IPopsicleList<CCKeyValueIntInt> IdToScoresMyList => null;

			public int IdToScoresMyCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresOppList => null;

			public int IdToScoresOppCount => 0;

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

			public Builder()
			{
			}

			internal Builder(CCGameTimeBegin cloneFrom)
			{
			}

			private CCGameTimeBegin PrepareBuilder()
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

			public override CCGameTimeBegin BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGameTimeBegin other)
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

			public Builder SetLevelId(int value)
			{
				return null;
			}

			public Builder ClearLevelId()
			{
				return null;
			}

			public Builder SetGameTime(int value)
			{
				return null;
			}

			public Builder ClearGameTime()
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

			public Builder SetTargetMoveTime(int value)
			{
				return null;
			}

			public Builder ClearTargetMoveTime()
			{
				return null;
			}
		}

		private static readonly CCGameTimeBegin defaultInstance;

		private static readonly string[] _cCGameTimeBeginFieldNames;

		private static readonly uint[] _cCGameTimeBeginFieldTags;

		public const int GameTypeFieldNumber = 1;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 2;

		private bool hasPvpType;

		private int pvpType_;

		public const int LevelIdFieldNumber = 9;

		private bool hasLevelId;

		private int levelId_;

		public const int GameTimeFieldNumber = 3;

		private bool hasGameTime;

		private int gameTime_;

		public const int RoundCountMyFieldNumber = 4;

		private PopsicleList<int> roundCountMy_;

		public const int RoundCountOppFieldNumber = 5;

		private PopsicleList<int> roundCountOpp_;

		public const int ScoreMyFieldNumber = 6;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 7;

		private PopsicleList<int> scoreOpp_;

		public const int RoundDataFieldNumber = 8;

		private bool hasRoundData;

		private CCRoundData roundData_;

		public const int IdToScoresMyFieldNumber = 10;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 11;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		public const int TargetMoveTimeFieldNumber = 12;

		private bool hasTargetMoveTime;

		private int targetMoveTime_;

		private int memoizedSerializedSize;

		public static CCGameTimeBegin DefaultInstance => null;

		public override CCGameTimeBegin DefaultInstanceForType => null;

		protected override CCGameTimeBegin ThisMessage => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasGameTime => false;

		public int GameTime => 0;

		public IList<int> RoundCountMyList => null;

		public int RoundCountMyCount => 0;

		public IList<int> RoundCountOppList => null;

		public int RoundCountOppCount => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public bool HasTargetMoveTime => false;

		public int TargetMoveTime => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGameTimeBegin()
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

		public static CCGameTimeBegin ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeBegin ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGameTimeBegin ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGameTimeBegin ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGameTimeBegin MakeReadOnly()
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

		public static Builder CreateBuilder(CCGameTimeBegin prototype)
		{
			return null;
		}

		static CCGameTimeBegin()
		{
		}
	}
}
