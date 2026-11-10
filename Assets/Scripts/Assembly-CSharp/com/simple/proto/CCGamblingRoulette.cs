using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamblingRoulette : GeneratedMessageLite<CCGamblingRoulette, CCGamblingRoulette.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamblingRoulette, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamblingRoulette result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamblingRoulette MessageBeingBuilt => null;

			public override CCGamblingRoulette DefaultInstanceForType => null;

			public bool HasPayGamblingTimes => false;

			public int PayGamblingTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasFreeLastRewardStartTimeMil => false;

			public long FreeLastRewardStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasFreeLastVideoStartTimeMil => false;

			public long FreeLastVideoStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasFreeLuckyPoints => false;

			public int FreeLuckyPoints
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPayLuckyPoints => false;

			public int PayLuckyPoints
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

			internal Builder(CCGamblingRoulette cloneFrom)
			{
			}

			private CCGamblingRoulette PrepareBuilder()
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

			public override CCGamblingRoulette BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamblingRoulette other)
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

			public Builder SetPayGamblingTimes(int value)
			{
				return null;
			}

			public Builder ClearPayGamblingTimes()
			{
				return null;
			}

			public Builder SetFreeLastRewardStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearFreeLastRewardStartTimeMil()
			{
				return null;
			}

			public Builder SetFreeLastVideoStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearFreeLastVideoStartTimeMil()
			{
				return null;
			}

			public Builder SetFreeLuckyPoints(int value)
			{
				return null;
			}

			public Builder ClearFreeLuckyPoints()
			{
				return null;
			}

			public Builder SetPayLuckyPoints(int value)
			{
				return null;
			}

			public Builder ClearPayLuckyPoints()
			{
				return null;
			}
		}

		private static readonly CCGamblingRoulette defaultInstance;

		private static readonly string[] _cCGamblingRouletteFieldNames;

		private static readonly uint[] _cCGamblingRouletteFieldTags;

		public const int PayGamblingTimesFieldNumber = 1;

		private bool hasPayGamblingTimes;

		private int payGamblingTimes_;

		public const int FreeLastRewardStartTimeMilFieldNumber = 3;

		private bool hasFreeLastRewardStartTimeMil;

		private long freeLastRewardStartTimeMil_;

		public const int FreeLastVideoStartTimeMilFieldNumber = 5;

		private bool hasFreeLastVideoStartTimeMil;

		private long freeLastVideoStartTimeMil_;

		public const int FreeLuckyPointsFieldNumber = 6;

		private bool hasFreeLuckyPoints;

		private int freeLuckyPoints_;

		public const int PayLuckyPointsFieldNumber = 7;

		private bool hasPayLuckyPoints;

		private int payLuckyPoints_;

		private int memoizedSerializedSize;

		public static CCGamblingRoulette DefaultInstance => null;

		public override CCGamblingRoulette DefaultInstanceForType => null;

		protected override CCGamblingRoulette ThisMessage => null;

		public bool HasPayGamblingTimes => false;

		public int PayGamblingTimes => 0;

		public bool HasFreeLastRewardStartTimeMil => false;

		public long FreeLastRewardStartTimeMil => 0L;

		public bool HasFreeLastVideoStartTimeMil => false;

		public long FreeLastVideoStartTimeMil => 0L;

		public bool HasFreeLuckyPoints => false;

		public int FreeLuckyPoints => 0;

		public bool HasPayLuckyPoints => false;

		public int PayLuckyPoints => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamblingRoulette()
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

		public static CCGamblingRoulette ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRoulette ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRoulette ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamblingRoulette ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamblingRoulette MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamblingRoulette prototype)
		{
			return null;
		}

		static CCGamblingRoulette()
		{
		}
	}
}
