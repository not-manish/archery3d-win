using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayerConWinChest : GeneratedMessageLite<CCPlayerConWinChest, CCPlayerConWinChest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayerConWinChest, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayerConWinChest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayerConWinChest MessageBeingBuilt => null;

			public override CCPlayerConWinChest DefaultInstanceForType => null;

			public bool HasHasChestReward => false;

			public bool HasChestReward
			{
				get
				{
					return false;
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

			public bool HasTodayConWin => false;

			public int TodayConWin
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTodayStartTimeMil => false;

			public long TodayStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasTodayStartMilNew => false;

			public long TodayStartMilNew
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasTodayConWinNew => false;

			public int TodayConWinNew
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardRoundNew => false;

			public int RewardRoundNew
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasNextChestIdNew => false;

			public int NextChestIdNew
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

			internal Builder(CCPlayerConWinChest cloneFrom)
			{
			}

			private CCPlayerConWinChest PrepareBuilder()
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

			public override CCPlayerConWinChest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayerConWinChest other)
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

			public Builder SetHasChestReward(bool value)
			{
				return null;
			}

			public Builder ClearHasChestReward()
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

			public Builder SetTodayConWin(int value)
			{
				return null;
			}

			public Builder ClearTodayConWin()
			{
				return null;
			}

			public Builder SetTodayStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearTodayStartTimeMil()
			{
				return null;
			}

			public Builder SetTodayStartMilNew(long value)
			{
				return null;
			}

			public Builder ClearTodayStartMilNew()
			{
				return null;
			}

			public Builder SetTodayConWinNew(int value)
			{
				return null;
			}

			public Builder ClearTodayConWinNew()
			{
				return null;
			}

			public Builder SetRewardRoundNew(int value)
			{
				return null;
			}

			public Builder ClearRewardRoundNew()
			{
				return null;
			}

			public Builder SetNextChestIdNew(int value)
			{
				return null;
			}

			public Builder ClearNextChestIdNew()
			{
				return null;
			}
		}

		private static readonly CCPlayerConWinChest defaultInstance;

		private static readonly string[] _cCPlayerConWinChestFieldNames;

		private static readonly uint[] _cCPlayerConWinChestFieldTags;

		public const int HasChestRewardFieldNumber = 1;

		private bool hasHasChestReward;

		private bool hasChestReward_;

		public const int ChestIdFieldNumber = 2;

		private bool hasChestId;

		private int chestId_;

		public const int TodayConWinFieldNumber = 3;

		private bool hasTodayConWin;

		private int todayConWin_;

		public const int TodayStartTimeMilFieldNumber = 4;

		private bool hasTodayStartTimeMil;

		private long todayStartTimeMil_;

		public const int TodayStartMilNewFieldNumber = 5;

		private bool hasTodayStartMilNew;

		private long todayStartMilNew_;

		public const int TodayConWinNewFieldNumber = 6;

		private bool hasTodayConWinNew;

		private int todayConWinNew_;

		public const int RewardRoundNewFieldNumber = 7;

		private bool hasRewardRoundNew;

		private int rewardRoundNew_;

		public const int NextChestIdNewFieldNumber = 8;

		private bool hasNextChestIdNew;

		private int nextChestIdNew_;

		private int memoizedSerializedSize;

		public static CCPlayerConWinChest DefaultInstance => null;

		public override CCPlayerConWinChest DefaultInstanceForType => null;

		protected override CCPlayerConWinChest ThisMessage => null;

		public bool HasHasChestReward => false;

		public bool HasChestReward => false;

		public bool HasChestId => false;

		public int ChestId => 0;

		public bool HasTodayConWin => false;

		public int TodayConWin => 0;

		public bool HasTodayStartTimeMil => false;

		public long TodayStartTimeMil => 0L;

		public bool HasTodayStartMilNew => false;

		public long TodayStartMilNew => 0L;

		public bool HasTodayConWinNew => false;

		public int TodayConWinNew => 0;

		public bool HasRewardRoundNew => false;

		public int RewardRoundNew => 0;

		public bool HasNextChestIdNew => false;

		public int NextChestIdNew => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayerConWinChest()
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

		public static CCPlayerConWinChest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayerConWinChest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayerConWinChest MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayerConWinChest prototype)
		{
			return null;
		}

		static CCPlayerConWinChest()
		{
		}
	}
}
