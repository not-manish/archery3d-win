using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoExtraResponse : GeneratedMessageLite<CCVideoExtraResponse, CCVideoExtraResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoExtraResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoExtraResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoExtraResponse MessageBeingBuilt => null;

			public override CCVideoExtraResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlayer => false;

			public CCPlayer Player
			{
				get
				{
					return null;
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

			internal Builder(CCVideoExtraResponse cloneFrom)
			{
			}

			private CCVideoExtraResponse PrepareBuilder()
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

			public override CCVideoExtraResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoExtraResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearPlayer()
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

		private static readonly CCVideoExtraResponse defaultInstance;

		private static readonly string[] _cCVideoExtraResponseFieldNames;

		private static readonly uint[] _cCVideoExtraResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int PlayerFieldNumber = 2;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int RewardTypeFieldNumber = 3;

		private bool hasRewardType;

		private int rewardType_;

		public const int RewardIdFieldNumber = 4;

		private bool hasRewardId;

		private int rewardId_;

		public const int RewardCountFieldNumber = 5;

		private bool hasRewardCount;

		private int rewardCount_;

		private int memoizedSerializedSize;

		public static CCVideoExtraResponse DefaultInstance => null;

		public override CCVideoExtraResponse DefaultInstanceForType => null;

		protected override CCVideoExtraResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasRewardType => false;

		public int RewardType => 0;

		public bool HasRewardId => false;

		public int RewardId => 0;

		public bool HasRewardCount => false;

		public int RewardCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoExtraResponse()
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

		public static CCVideoExtraResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoExtraResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoExtraResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoExtraResponse prototype)
		{
			return null;
		}

		static CCVideoExtraResponse()
		{
		}
	}
}
