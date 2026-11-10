using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBuyShopResponse : GeneratedMessageLite<CCBuyShopResponse, CCBuyShopResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBuyShopResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCBuyShopResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBuyShopResponse MessageBeingBuilt => null;

			public override CCBuyShopResponse DefaultInstanceForType => null;

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

			public bool HasShopBuyType => false;

			public int ShopBuyType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShopBuyId => false;

			public int ShopBuyId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShopBuyIndex => false;

			public int ShopBuyIndex
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

			public bool HasBiilData => false;

			public CCBillData BiilData
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

			internal Builder(CCBuyShopResponse cloneFrom)
			{
			}

			private CCBuyShopResponse PrepareBuilder()
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

			public override CCBuyShopResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBuyShopResponse other)
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

			public Builder SetShopBuyType(int value)
			{
				return null;
			}

			public Builder ClearShopBuyType()
			{
				return null;
			}

			public Builder SetShopBuyId(int value)
			{
				return null;
			}

			public Builder ClearShopBuyId()
			{
				return null;
			}

			public Builder SetShopBuyIndex(int value)
			{
				return null;
			}

			public Builder ClearShopBuyIndex()
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

			public Builder SetBiilData(CCBillData value)
			{
				return null;
			}

			public Builder SetBiilData(CCBillData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeBiilData(CCBillData value)
			{
				return null;
			}

			public Builder ClearBiilData()
			{
				return null;
			}
		}

		private static readonly CCBuyShopResponse defaultInstance;

		private static readonly string[] _cCBuyShopResponseFieldNames;

		private static readonly uint[] _cCBuyShopResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int ShopBuyTypeFieldNumber = 3;

		private bool hasShopBuyType;

		private int shopBuyType_;

		public const int ShopBuyIdFieldNumber = 4;

		private bool hasShopBuyId;

		private int shopBuyId_;

		public const int ShopBuyIndexFieldNumber = 5;

		private bool hasShopBuyIndex;

		private int shopBuyIndex_;

		public const int ChestRewardFieldNumber = 6;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		public const int PlayerFieldNumber = 7;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int BiilDataFieldNumber = 8;

		private bool hasBiilData;

		private CCBillData biilData_;

		private int memoizedSerializedSize;

		public static CCBuyShopResponse DefaultInstance => null;

		public override CCBuyShopResponse DefaultInstanceForType => null;

		protected override CCBuyShopResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasShopBuyType => false;

		public int ShopBuyType => 0;

		public bool HasShopBuyId => false;

		public int ShopBuyId => 0;

		public bool HasShopBuyIndex => false;

		public int ShopBuyIndex => 0;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasBiilData => false;

		public CCBillData BiilData => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBuyShopResponse()
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

		public static CCBuyShopResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBuyShopResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBuyShopResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBuyShopResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCBuyShopResponse prototype)
		{
			return null;
		}

		static CCBuyShopResponse()
		{
		}
	}
}
