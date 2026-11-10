using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoFreeData : GeneratedMessageLite<CCVideoFreeData, CCVideoFreeData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoFreeData, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoFreeData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoFreeData MessageBeingBuilt => null;

			public override CCVideoFreeData DefaultInstanceForType => null;

			public bool HasLastUpdateTime => false;

			public long LastUpdateTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasRewardLeftTimes => false;

			public int RewardLeftTimes
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

			internal Builder(CCVideoFreeData cloneFrom)
			{
			}

			private CCVideoFreeData PrepareBuilder()
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

			public override CCVideoFreeData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoFreeData other)
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

			public Builder SetLastUpdateTime(long value)
			{
				return null;
			}

			public Builder ClearLastUpdateTime()
			{
				return null;
			}

			public Builder SetRewardLeftTimes(int value)
			{
				return null;
			}

			public Builder ClearRewardLeftTimes()
			{
				return null;
			}
		}

		private static readonly CCVideoFreeData defaultInstance;

		private static readonly string[] _cCVideoFreeDataFieldNames;

		private static readonly uint[] _cCVideoFreeDataFieldTags;

		public const int LastUpdateTimeFieldNumber = 1;

		private bool hasLastUpdateTime;

		private long lastUpdateTime_;

		public const int RewardLeftTimesFieldNumber = 2;

		private bool hasRewardLeftTimes;

		private int rewardLeftTimes_;

		private int memoizedSerializedSize;

		public static CCVideoFreeData DefaultInstance => null;

		public override CCVideoFreeData DefaultInstanceForType => null;

		protected override CCVideoFreeData ThisMessage => null;

		public bool HasLastUpdateTime => false;

		public long LastUpdateTime => 0L;

		public bool HasRewardLeftTimes => false;

		public int RewardLeftTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoFreeData()
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

		public static CCVideoFreeData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoFreeData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoFreeData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoFreeData MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoFreeData prototype)
		{
			return null;
		}

		static CCVideoFreeData()
		{
		}
	}
}
