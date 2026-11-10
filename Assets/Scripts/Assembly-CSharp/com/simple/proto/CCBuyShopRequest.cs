using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBuyShopRequest : GeneratedMessageLite<CCBuyShopRequest, CCBuyShopRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBuyShopRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCBuyShopRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBuyShopRequest MessageBeingBuilt => null;

			public override CCBuyShopRequest DefaultInstanceForType => null;

			public bool HasUid => false;

			public string Uid
			{
				get
				{
					return null;
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

			public bool HasBillData => false;

			public CCBillData BillData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasBuyReason => false;

			public int BuyReason
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

			internal Builder(CCBuyShopRequest cloneFrom)
			{
			}

			private CCBuyShopRequest PrepareBuilder()
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

			public override CCBuyShopRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBuyShopRequest other)
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

			public Builder SetUid(string value)
			{
				return null;
			}

			public Builder ClearUid()
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

			public Builder SetBillData(CCBillData value)
			{
				return null;
			}

			public Builder SetBillData(CCBillData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeBillData(CCBillData value)
			{
				return null;
			}

			public Builder ClearBillData()
			{
				return null;
			}

			public Builder SetBuyReason(int value)
			{
				return null;
			}

			public Builder ClearBuyReason()
			{
				return null;
			}
		}

		private static readonly CCBuyShopRequest defaultInstance;

		private static readonly string[] _cCBuyShopRequestFieldNames;

		private static readonly uint[] _cCBuyShopRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int ShopBuyTypeFieldNumber = 2;

		private bool hasShopBuyType;

		private int shopBuyType_;

		public const int ShopBuyIdFieldNumber = 3;

		private bool hasShopBuyId;

		private int shopBuyId_;

		public const int ShopBuyIndexFieldNumber = 4;

		private bool hasShopBuyIndex;

		private int shopBuyIndex_;

		public const int BillDataFieldNumber = 5;

		private bool hasBillData;

		private CCBillData billData_;

		public const int BuyReasonFieldNumber = 6;

		private bool hasBuyReason;

		private int buyReason_;

		private int memoizedSerializedSize;

		public static CCBuyShopRequest DefaultInstance => null;

		public override CCBuyShopRequest DefaultInstanceForType => null;

		protected override CCBuyShopRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasShopBuyType => false;

		public int ShopBuyType => 0;

		public bool HasShopBuyId => false;

		public int ShopBuyId => 0;

		public bool HasShopBuyIndex => false;

		public int ShopBuyIndex => 0;

		public bool HasBillData => false;

		public CCBillData BillData => null;

		public bool HasBuyReason => false;

		public int BuyReason => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBuyShopRequest()
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

		public static CCBuyShopRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBuyShopRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBuyShopRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBuyShopRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCBuyShopRequest prototype)
		{
			return null;
		}

		static CCBuyShopRequest()
		{
		}
	}
}
