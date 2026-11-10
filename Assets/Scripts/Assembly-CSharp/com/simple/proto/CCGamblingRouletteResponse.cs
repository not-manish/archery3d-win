using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamblingRouletteResponse : GeneratedMessageLite<CCGamblingRouletteResponse, CCGamblingRouletteResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamblingRouletteResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamblingRouletteResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamblingRouletteResponse MessageBeingBuilt => null;

			public override CCGamblingRouletteResponse DefaultInstanceForType => null;

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

			public bool HasReason => false;

			public int Reason
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRouletteType => false;

			public int RouletteType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRouletteId => false;

			public int RouletteId
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

			internal Builder(CCGamblingRouletteResponse cloneFrom)
			{
			}

			private CCGamblingRouletteResponse PrepareBuilder()
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

			public override CCGamblingRouletteResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamblingRouletteResponse other)
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

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
			{
				return null;
			}

			public Builder SetRouletteType(int value)
			{
				return null;
			}

			public Builder ClearRouletteType()
			{
				return null;
			}

			public Builder SetRouletteId(int value)
			{
				return null;
			}

			public Builder ClearRouletteId()
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

		private static readonly CCGamblingRouletteResponse defaultInstance;

		private static readonly string[] _cCGamblingRouletteResponseFieldNames;

		private static readonly uint[] _cCGamblingRouletteResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int RouletteTypeFieldNumber = 3;

		private bool hasRouletteType;

		private int rouletteType_;

		public const int RouletteIdFieldNumber = 4;

		private bool hasRouletteId;

		private int rouletteId_;

		public const int PlayerFieldNumber = 5;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 6;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		private int memoizedSerializedSize;

		public static CCGamblingRouletteResponse DefaultInstance => null;

		public override CCGamblingRouletteResponse DefaultInstanceForType => null;

		protected override CCGamblingRouletteResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasRouletteType => false;

		public int RouletteType => 0;

		public bool HasRouletteId => false;

		public int RouletteId => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamblingRouletteResponse()
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

		public static CCGamblingRouletteResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamblingRouletteResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamblingRouletteResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamblingRouletteResponse prototype)
		{
			return null;
		}

		static CCGamblingRouletteResponse()
		{
		}
	}
}
