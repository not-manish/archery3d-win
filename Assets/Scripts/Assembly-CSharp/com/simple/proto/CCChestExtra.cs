using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestExtra : GeneratedMessageLite<CCChestExtra, CCChestExtra.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestExtra, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestExtra result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestExtra MessageBeingBuilt => null;

			public override CCChestExtra DefaultInstanceForType => null;

			public bool HasLastAppTimeMil => false;

			public long LastAppTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasHasReward => false;

			public bool HasReward
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasDoubleType => false;

			public int DoubleType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardType => false;

			public int RewardType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardId => false;

			public int RewardId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardCount => false;

			public int RewardCount
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

			internal Builder(CCChestExtra cloneFrom)
			{
			}

			private CCChestExtra PrepareBuilder()
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

			public override CCChestExtra BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestExtra other)
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

			public Builder SetLastAppTimeMil(long value)
			{
				return null;
			}

			public Builder ClearLastAppTimeMil()
			{
				return null;
			}

			public Builder SetHasReward(bool value)
			{
				return null;
			}

			public Builder ClearHasReward()
			{
				return null;
			}

			public Builder SetDoubleType(int value)
			{
				return null;
			}

			public Builder ClearDoubleType()
			{
				return null;
			}

			public Builder SetRewardType(int value)
			{
				return null;
			}

			public Builder ClearRewardType()
			{
				return null;
			}

			public Builder SetRewardId(int value)
			{
				return null;
			}

			public Builder ClearRewardId()
			{
				return null;
			}

			public Builder SetRewardCount(int value)
			{
				return null;
			}

			public Builder ClearRewardCount()
			{
				return null;
			}
		}

		private static readonly CCChestExtra defaultInstance;

		private static readonly string[] _cCChestExtraFieldNames;

		private static readonly uint[] _cCChestExtraFieldTags;

		public const int LastAppTimeMilFieldNumber = 1;

		private bool hasLastAppTimeMil;

		private long lastAppTimeMil_;

		public const int HasRewardFieldNumber = 2;

		private bool hasHasReward;

		private bool hasReward_;

		public const int DoubleTypeFieldNumber = 3;

		private bool hasDoubleType;

		private int doubleType_;

		public const int RewardTypeFieldNumber = 4;

		private bool hasRewardType;

		private int rewardType_;

		public const int RewardIdFieldNumber = 5;

		private bool hasRewardId;

		private int rewardId_;

		public const int RewardCountFieldNumber = 6;

		private bool hasRewardCount;

		private int rewardCount_;

		private int memoizedSerializedSize;

		public static CCChestExtra DefaultInstance => null;

		public override CCChestExtra DefaultInstanceForType => null;

		protected override CCChestExtra ThisMessage => null;

		public bool HasLastAppTimeMil => false;

		public long LastAppTimeMil => 0L;

		public bool HasHasReward => false;

		public bool HasReward => false;

		public bool HasDoubleType => false;

		public int DoubleType => 0;

		public bool HasRewardType => false;

		public int RewardType => 0;

		public bool HasRewardId => false;

		public int RewardId => 0;

		public bool HasRewardCount => false;

		public int RewardCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestExtra()
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

		public static CCChestExtra ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestExtra ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestExtra ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestExtra ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestExtra MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestExtra prototype)
		{
			return null;
		}

		static CCChestExtra()
		{
		}
	}
}
