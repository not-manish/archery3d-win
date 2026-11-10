using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleLevelRewardResponse : GeneratedMessageLite<CCSingleLevelRewardResponse, CCSingleLevelRewardResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleLevelRewardResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleLevelRewardResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleLevelRewardResponse MessageBeingBuilt => null;

			public override CCSingleLevelRewardResponse DefaultInstanceForType => null;

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

			public bool HasChestReward => false;

			public CCChestReward ChestReward
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCSingleLevelRewardResponse cloneFrom)
			{
			}

			private CCSingleLevelRewardResponse PrepareBuilder()
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

			public override CCSingleLevelRewardResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleLevelRewardResponse other)
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

			public Builder SetHasReward(bool value)
			{
				return null;
			}

			public Builder ClearHasReward()
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

			public Builder SetChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder SetChestReward(CCChestReward.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder ClearChestReward()
			{
				return null;
			}
		}

		private static readonly CCSingleLevelRewardResponse defaultInstance;

		private static readonly string[] _cCSingleLevelRewardResponseFieldNames;

		private static readonly uint[] _cCSingleLevelRewardResponseFieldTags;

		public const int HasRewardFieldNumber = 1;

		private bool hasHasReward;

		private bool hasReward_;

		public const int PlayerFieldNumber = 2;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int RewardTypeFieldNumber = 3;

		private bool hasRewardType;

		private int rewardType_;

		public const int ChestRewardFieldNumber = 4;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		private int memoizedSerializedSize;

		public static CCSingleLevelRewardResponse DefaultInstance => null;

		public override CCSingleLevelRewardResponse DefaultInstanceForType => null;

		protected override CCSingleLevelRewardResponse ThisMessage => null;

		public bool HasHasReward => false;

		public bool HasReward => false;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasRewardType => false;

		public int RewardType => 0;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleLevelRewardResponse()
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

		public static CCSingleLevelRewardResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleLevelRewardResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleLevelRewardResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleLevelRewardResponse prototype)
		{
			return null;
		}

		static CCSingleLevelRewardResponse()
		{
		}
	}
}
