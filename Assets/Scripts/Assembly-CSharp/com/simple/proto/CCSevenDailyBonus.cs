using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSevenDailyBonus : GeneratedMessageLite<CCSevenDailyBonus, CCSevenDailyBonus.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSevenDailyBonus, Builder>
		{
			private bool resultIsReadOnly;

			private CCSevenDailyBonus result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSevenDailyBonus MessageBeingBuilt => null;

			public override CCSevenDailyBonus DefaultInstanceForType => null;

			public bool HasLastBonusDayStartTimeMil => false;

			public long LastBonusDayStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasDailyRewardRound => false;

			public int DailyRewardRound
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasDailyRewardedIndex => false;

			public int DailyRewardedIndex
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

			internal Builder(CCSevenDailyBonus cloneFrom)
			{
			}

			private CCSevenDailyBonus PrepareBuilder()
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

			public override CCSevenDailyBonus BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSevenDailyBonus other)
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

			public Builder SetLastBonusDayStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearLastBonusDayStartTimeMil()
			{
				return null;
			}

			public Builder SetDailyRewardRound(int value)
			{
				return null;
			}

			public Builder ClearDailyRewardRound()
			{
				return null;
			}

			public Builder SetDailyRewardedIndex(int value)
			{
				return null;
			}

			public Builder ClearDailyRewardedIndex()
			{
				return null;
			}
		}

		private static readonly CCSevenDailyBonus defaultInstance;

		private static readonly string[] _cCSevenDailyBonusFieldNames;

		private static readonly uint[] _cCSevenDailyBonusFieldTags;

		public const int LastBonusDayStartTimeMilFieldNumber = 2;

		private bool hasLastBonusDayStartTimeMil;

		private long lastBonusDayStartTimeMil_;

		public const int DailyRewardRoundFieldNumber = 3;

		private bool hasDailyRewardRound;

		private int dailyRewardRound_;

		public const int DailyRewardedIndexFieldNumber = 4;

		private bool hasDailyRewardedIndex;

		private int dailyRewardedIndex_;

		private int memoizedSerializedSize;

		public static CCSevenDailyBonus DefaultInstance => null;

		public override CCSevenDailyBonus DefaultInstanceForType => null;

		protected override CCSevenDailyBonus ThisMessage => null;

		public bool HasLastBonusDayStartTimeMil => false;

		public long LastBonusDayStartTimeMil => 0L;

		public bool HasDailyRewardRound => false;

		public int DailyRewardRound => 0;

		public bool HasDailyRewardedIndex => false;

		public int DailyRewardedIndex => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSevenDailyBonus()
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

		public static CCSevenDailyBonus ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSevenDailyBonus ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSevenDailyBonus MakeReadOnly()
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

		public static Builder CreateBuilder(CCSevenDailyBonus prototype)
		{
			return null;
		}

		static CCSevenDailyBonus()
		{
		}
	}
}
