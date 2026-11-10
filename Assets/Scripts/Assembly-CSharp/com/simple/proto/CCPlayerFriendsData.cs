using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayerFriendsData : GeneratedMessageLite<CCPlayerFriendsData, CCPlayerFriendsData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayerFriendsData, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayerFriendsData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayerFriendsData MessageBeingBuilt => null;

			public override CCPlayerFriendsData DefaultInstanceForType => null;

			public bool HasLastSendGiftsDayStartTime => false;

			public long LastSendGiftsDayStartTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasSendGiftsNum => false;

			public int SendGiftsNum
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastRewardGiftsDayStartTime => false;

			public long LastRewardGiftsDayStartTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasRewardGiftsGoldCount => false;

			public int RewardGiftsGoldCount
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

			internal Builder(CCPlayerFriendsData cloneFrom)
			{
			}

			private CCPlayerFriendsData PrepareBuilder()
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

			public override CCPlayerFriendsData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayerFriendsData other)
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

			public Builder SetLastSendGiftsDayStartTime(long value)
			{
				return null;
			}

			public Builder ClearLastSendGiftsDayStartTime()
			{
				return null;
			}

			public Builder SetSendGiftsNum(int value)
			{
				return null;
			}

			public Builder ClearSendGiftsNum()
			{
				return null;
			}

			public Builder SetLastRewardGiftsDayStartTime(long value)
			{
				return null;
			}

			public Builder ClearLastRewardGiftsDayStartTime()
			{
				return null;
			}

			public Builder SetRewardGiftsGoldCount(int value)
			{
				return null;
			}

			public Builder ClearRewardGiftsGoldCount()
			{
				return null;
			}
		}

		private static readonly CCPlayerFriendsData defaultInstance;

		private static readonly string[] _cCPlayerFriendsDataFieldNames;

		private static readonly uint[] _cCPlayerFriendsDataFieldTags;

		public const int LastSendGiftsDayStartTimeFieldNumber = 2;

		private bool hasLastSendGiftsDayStartTime;

		private long lastSendGiftsDayStartTime_;

		public const int SendGiftsNumFieldNumber = 3;

		private bool hasSendGiftsNum;

		private int sendGiftsNum_;

		public const int LastRewardGiftsDayStartTimeFieldNumber = 5;

		private bool hasLastRewardGiftsDayStartTime;

		private long lastRewardGiftsDayStartTime_;

		public const int RewardGiftsGoldCountFieldNumber = 6;

		private bool hasRewardGiftsGoldCount;

		private int rewardGiftsGoldCount_;

		private int memoizedSerializedSize;

		public static CCPlayerFriendsData DefaultInstance => null;

		public override CCPlayerFriendsData DefaultInstanceForType => null;

		protected override CCPlayerFriendsData ThisMessage => null;

		public bool HasLastSendGiftsDayStartTime => false;

		public long LastSendGiftsDayStartTime => 0L;

		public bool HasSendGiftsNum => false;

		public int SendGiftsNum => 0;

		public bool HasLastRewardGiftsDayStartTime => false;

		public long LastRewardGiftsDayStartTime => 0L;

		public bool HasRewardGiftsGoldCount => false;

		public int RewardGiftsGoldCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayerFriendsData()
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

		public static CCPlayerFriendsData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayerFriendsData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayerFriendsData MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayerFriendsData prototype)
		{
			return null;
		}

		static CCPlayerFriendsData()
		{
		}
	}
}
