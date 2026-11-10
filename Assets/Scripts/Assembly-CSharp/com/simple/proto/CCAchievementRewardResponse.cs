using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAchievementRewardResponse : GeneratedMessageLite<CCAchievementRewardResponse, CCAchievementRewardResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAchievementRewardResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCAchievementRewardResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAchievementRewardResponse MessageBeingBuilt => null;

			public override CCAchievementRewardResponse DefaultInstanceForType => null;

			public bool HasResult => false;

			public int Result
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAchievementType => false;

			public int AchievementType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAchievementSubType => false;

			public int AchievementSubType
			{
				get
				{
					return 0;
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

			internal Builder(CCAchievementRewardResponse cloneFrom)
			{
			}

			private CCAchievementRewardResponse PrepareBuilder()
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

			public override CCAchievementRewardResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAchievementRewardResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public Builder SetAchievementType(int value)
			{
				return null;
			}

			public Builder ClearAchievementType()
			{
				return null;
			}

			public Builder SetAchievementSubType(int value)
			{
				return null;
			}

			public Builder ClearAchievementSubType()
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

		private static readonly CCAchievementRewardResponse defaultInstance;

		private static readonly string[] _cCAchievementRewardResponseFieldNames;

		private static readonly uint[] _cCAchievementRewardResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int AchievementTypeFieldNumber = 2;

		private bool hasAchievementType;

		private int achievementType_;

		public const int AchievementSubTypeFieldNumber = 3;

		private bool hasAchievementSubType;

		private int achievementSubType_;

		public const int PlayerFieldNumber = 4;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 5;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		private int memoizedSerializedSize;

		public static CCAchievementRewardResponse DefaultInstance => null;

		public override CCAchievementRewardResponse DefaultInstanceForType => null;

		protected override CCAchievementRewardResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasAchievementType => false;

		public int AchievementType => 0;

		public bool HasAchievementSubType => false;

		public int AchievementSubType => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAchievementRewardResponse()
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

		public static CCAchievementRewardResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAchievementRewardResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAchievementRewardResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCAchievementRewardResponse prototype)
		{
			return null;
		}

		static CCAchievementRewardResponse()
		{
		}
	}
}
