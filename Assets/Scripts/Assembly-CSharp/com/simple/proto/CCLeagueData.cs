using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLeagueData : GeneratedMessageLite<CCLeagueData, CCLeagueData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLeagueData, Builder>
		{
			private bool resultIsReadOnly;

			private CCLeagueData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLeagueData MessageBeingBuilt => null;

			public override CCLeagueData DefaultInstanceForType => null;

			public bool HasLastSeasonLeagueId => false;

			public int LastSeasonLeagueId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonSegment => false;

			public int LastSeasonSegment
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonSegmentRoomId => false;

			public string LastSeasonSegmentRoomId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLastSeasonHasReward => false;

			public bool LastSeasonHasReward
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasLastSeasonRank => false;

			public int LastSeasonRank
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLeagueId => false;

			public int LeagueId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSegment => false;

			public int Segment
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSegmentRoomId => false;

			public string SegmentRoomId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasCurRank => false;

			public int CurRank
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastRank => false;

			public int LastRank
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasStartTime => false;

			public long StartTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasDurationTime => false;

			public long DurationTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCLeagueData cloneFrom)
			{
			}

			private CCLeagueData PrepareBuilder()
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

			public override CCLeagueData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLeagueData other)
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

			public Builder SetLastSeasonLeagueId(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonLeagueId()
			{
				return null;
			}

			public Builder SetLastSeasonSegment(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonSegment()
			{
				return null;
			}

			public Builder SetLastSeasonSegmentRoomId(string value)
			{
				return null;
			}

			public Builder ClearLastSeasonSegmentRoomId()
			{
				return null;
			}

			public Builder SetLastSeasonHasReward(bool value)
			{
				return null;
			}

			public Builder ClearLastSeasonHasReward()
			{
				return null;
			}

			public Builder SetLastSeasonRank(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonRank()
			{
				return null;
			}

			public Builder SetLeagueId(int value)
			{
				return null;
			}

			public Builder ClearLeagueId()
			{
				return null;
			}

			public Builder SetSegment(int value)
			{
				return null;
			}

			public Builder ClearSegment()
			{
				return null;
			}

			public Builder SetSegmentRoomId(string value)
			{
				return null;
			}

			public Builder ClearSegmentRoomId()
			{
				return null;
			}

			public Builder SetCurRank(int value)
			{
				return null;
			}

			public Builder ClearCurRank()
			{
				return null;
			}

			public Builder SetLastRank(int value)
			{
				return null;
			}

			public Builder ClearLastRank()
			{
				return null;
			}

			public Builder SetStartTime(long value)
			{
				return null;
			}

			public Builder ClearStartTime()
			{
				return null;
			}

			public Builder SetDurationTime(long value)
			{
				return null;
			}

			public Builder ClearDurationTime()
			{
				return null;
			}
		}

		private static readonly CCLeagueData defaultInstance;

		private static readonly string[] _cCLeagueDataFieldNames;

		private static readonly uint[] _cCLeagueDataFieldTags;

		public const int LastSeasonLeagueIdFieldNumber = 1;

		private bool hasLastSeasonLeagueId;

		private int lastSeasonLeagueId_;

		public const int LastSeasonSegmentFieldNumber = 2;

		private bool hasLastSeasonSegment;

		private int lastSeasonSegment_;

		public const int LastSeasonSegmentRoomIdFieldNumber = 3;

		private bool hasLastSeasonSegmentRoomId;

		private string lastSeasonSegmentRoomId_;

		public const int LastSeasonHasRewardFieldNumber = 4;

		private bool hasLastSeasonHasReward;

		private bool lastSeasonHasReward_;

		public const int LastSeasonRankFieldNumber = 5;

		private bool hasLastSeasonRank;

		private int lastSeasonRank_;

		public const int LeagueIdFieldNumber = 6;

		private bool hasLeagueId;

		private int leagueId_;

		public const int SegmentFieldNumber = 7;

		private bool hasSegment;

		private int segment_;

		public const int SegmentRoomIdFieldNumber = 8;

		private bool hasSegmentRoomId;

		private string segmentRoomId_;

		public const int CurRankFieldNumber = 9;

		private bool hasCurRank;

		private int curRank_;

		public const int LastRankFieldNumber = 10;

		private bool hasLastRank;

		private int lastRank_;

		public const int StartTimeFieldNumber = 11;

		private bool hasStartTime;

		private long startTime_;

		public const int DurationTimeFieldNumber = 12;

		private bool hasDurationTime;

		private long durationTime_;

		private int memoizedSerializedSize;

		public static CCLeagueData DefaultInstance => null;

		public override CCLeagueData DefaultInstanceForType => null;

		protected override CCLeagueData ThisMessage => null;

		public bool HasLastSeasonLeagueId => false;

		public int LastSeasonLeagueId => 0;

		public bool HasLastSeasonSegment => false;

		public int LastSeasonSegment => 0;

		public bool HasLastSeasonSegmentRoomId => false;

		public string LastSeasonSegmentRoomId => null;

		public bool HasLastSeasonHasReward => false;

		public bool LastSeasonHasReward => false;

		public bool HasLastSeasonRank => false;

		public int LastSeasonRank => 0;

		public bool HasLeagueId => false;

		public int LeagueId => 0;

		public bool HasSegment => false;

		public int Segment => 0;

		public bool HasSegmentRoomId => false;

		public string SegmentRoomId => null;

		public bool HasCurRank => false;

		public int CurRank => 0;

		public bool HasLastRank => false;

		public int LastRank => 0;

		public bool HasStartTime => false;

		public long StartTime => 0L;

		public bool HasDurationTime => false;

		public long DurationTime => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLeagueData()
		{
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

		public static CCLeagueData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLeagueData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLeagueData MakeReadOnly()
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

		public static Builder CreateBuilder(CCLeagueData prototype)
		{
			return null;
		}

		static CCLeagueData()
		{
		}
	}
}
