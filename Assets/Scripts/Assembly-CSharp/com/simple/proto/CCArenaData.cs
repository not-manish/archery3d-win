using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCArenaData : GeneratedMessageLite<CCArenaData, CCArenaData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCArenaData, Builder>
		{
			private bool resultIsReadOnly;

			private CCArenaData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCArenaData MessageBeingBuilt => null;

			public override CCArenaData DefaultInstanceForType => null;

			public bool HasHasJoin => false;

			public bool HasJoin
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasArenaType => false;

			public int ArenaType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasJoinTimestamp => false;

			public long JoinTimestamp
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasSumGames => false;

			public int SumGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasWinGames => false;

			public int WinGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLoseGames => false;

			public int LoseGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArenaFinishedTimes => false;

			public int ArenaFinishedTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAverageWins => false;

			public float AverageWins
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public IPopsicleList<CCArenaLevel> LevelInfosList => null;

			public int LevelInfosCount => 0;

			public Builder()
			{
			}

			internal Builder(CCArenaData cloneFrom)
			{
			}

			private CCArenaData PrepareBuilder()
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

			public override CCArenaData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCArenaData other)
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

			public Builder SetHasJoin(bool value)
			{
				return null;
			}

			public Builder ClearHasJoin()
			{
				return null;
			}

			public Builder SetArenaType(int value)
			{
				return null;
			}

			public Builder ClearArenaType()
			{
				return null;
			}

			public Builder SetJoinTimestamp(long value)
			{
				return null;
			}

			public Builder ClearJoinTimestamp()
			{
				return null;
			}

			public Builder SetSumGames(int value)
			{
				return null;
			}

			public Builder ClearSumGames()
			{
				return null;
			}

			public Builder SetWinGames(int value)
			{
				return null;
			}

			public Builder ClearWinGames()
			{
				return null;
			}

			public Builder SetLoseGames(int value)
			{
				return null;
			}

			public Builder ClearLoseGames()
			{
				return null;
			}

			public Builder SetArenaFinishedTimes(int value)
			{
				return null;
			}

			public Builder ClearArenaFinishedTimes()
			{
				return null;
			}

			public Builder SetAverageWins(float value)
			{
				return null;
			}

			public Builder ClearAverageWins()
			{
				return null;
			}

			public CCArenaLevel GetLevelInfos(int index)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCArenaLevel value)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCArenaLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddLevelInfos(CCArenaLevel value)
			{
				return null;
			}

			public Builder AddLevelInfos(CCArenaLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeLevelInfos(IEnumerable<CCArenaLevel> values)
			{
				return null;
			}

			public Builder ClearLevelInfos()
			{
				return null;
			}
		}

		private static readonly CCArenaData defaultInstance;

		private static readonly string[] _cCArenaDataFieldNames;

		private static readonly uint[] _cCArenaDataFieldTags;

		public const int HasJoinFieldNumber = 2;

		private bool hasHasJoin;

		private bool hasJoin_;

		public const int ArenaTypeFieldNumber = 1;

		private bool hasArenaType;

		private int arenaType_;

		public const int JoinTimestampFieldNumber = 3;

		private bool hasJoinTimestamp;

		private long joinTimestamp_;

		public const int SumGamesFieldNumber = 5;

		private bool hasSumGames;

		private int sumGames_;

		public const int WinGamesFieldNumber = 6;

		private bool hasWinGames;

		private int winGames_;

		public const int LoseGamesFieldNumber = 7;

		private bool hasLoseGames;

		private int loseGames_;

		public const int ArenaFinishedTimesFieldNumber = 8;

		private bool hasArenaFinishedTimes;

		private int arenaFinishedTimes_;

		public const int AverageWinsFieldNumber = 9;

		private bool hasAverageWins;

		private float averageWins_;

		public const int LevelInfosFieldNumber = 10;

		private PopsicleList<CCArenaLevel> levelInfos_;

		private int memoizedSerializedSize;

		public static CCArenaData DefaultInstance => null;

		public override CCArenaData DefaultInstanceForType => null;

		protected override CCArenaData ThisMessage => null;

		public bool HasHasJoin => false;

		public bool HasJoin => false;

		public bool HasArenaType => false;

		public int ArenaType => 0;

		public bool HasJoinTimestamp => false;

		public long JoinTimestamp => 0L;

		public bool HasSumGames => false;

		public int SumGames => 0;

		public bool HasWinGames => false;

		public int WinGames => 0;

		public bool HasLoseGames => false;

		public int LoseGames => 0;

		public bool HasArenaFinishedTimes => false;

		public int ArenaFinishedTimes => 0;

		public bool HasAverageWins => false;

		public float AverageWins => 0f;

		public IList<CCArenaLevel> LevelInfosList => null;

		public int LevelInfosCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCArenaData()
		{
		}

		public CCArenaLevel GetLevelInfos(int index)
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

		public static CCArenaData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCArenaData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCArenaData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCArenaData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCArenaData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCArenaData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCArenaData MakeReadOnly()
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

		public static Builder CreateBuilder(CCArenaData prototype)
		{
			return null;
		}

		static CCArenaData()
		{
		}
	}
}
