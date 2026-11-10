using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleBuyObjectsRequest : GeneratedMessageLite<CCSingleBuyObjectsRequest, CCSingleBuyObjectsRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleBuyObjectsRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleBuyObjectsRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleBuyObjectsRequest MessageBeingBuilt => null;

			public override CCSingleBuyObjectsRequest DefaultInstanceForType => null;

			public bool HasBuyType => false;

			public int BuyType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevelId => false;

			public int LevelId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBuyTimes => false;

			public int BuyTimes
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

			internal Builder(CCSingleBuyObjectsRequest cloneFrom)
			{
			}

			private CCSingleBuyObjectsRequest PrepareBuilder()
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

			public override CCSingleBuyObjectsRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleBuyObjectsRequest other)
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

			public Builder SetBuyType(int value)
			{
				return null;
			}

			public Builder ClearBuyType()
			{
				return null;
			}

			public Builder SetLevelId(int value)
			{
				return null;
			}

			public Builder ClearLevelId()
			{
				return null;
			}

			public Builder SetBuyTimes(int value)
			{
				return null;
			}

			public Builder ClearBuyTimes()
			{
				return null;
			}
		}

		private static readonly CCSingleBuyObjectsRequest defaultInstance;

		private static readonly string[] _cCSingleBuyObjectsRequestFieldNames;

		private static readonly uint[] _cCSingleBuyObjectsRequestFieldTags;

		public const int BuyTypeFieldNumber = 2;

		private bool hasBuyType;

		private int buyType_;

		public const int LevelIdFieldNumber = 3;

		private bool hasLevelId;

		private int levelId_;

		public const int BuyTimesFieldNumber = 4;

		private bool hasBuyTimes;

		private int buyTimes_;

		private int memoizedSerializedSize;

		public static CCSingleBuyObjectsRequest DefaultInstance => null;

		public override CCSingleBuyObjectsRequest DefaultInstanceForType => null;

		protected override CCSingleBuyObjectsRequest ThisMessage => null;

		public bool HasBuyType => false;

		public int BuyType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasBuyTimes => false;

		public int BuyTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleBuyObjectsRequest()
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

		public static CCSingleBuyObjectsRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleBuyObjectsRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleBuyObjectsRequest prototype)
		{
			return null;
		}

		static CCSingleBuyObjectsRequest()
		{
		}
	}
}
