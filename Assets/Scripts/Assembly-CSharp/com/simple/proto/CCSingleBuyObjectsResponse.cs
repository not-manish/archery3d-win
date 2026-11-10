using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleBuyObjectsResponse : GeneratedMessageLite<CCSingleBuyObjectsResponse, CCSingleBuyObjectsResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleBuyObjectsResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleBuyObjectsResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleBuyObjectsResponse MessageBeingBuilt => null;

			public override CCSingleBuyObjectsResponse DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCSingleBuyObjectsResponse cloneFrom)
			{
			}

			private CCSingleBuyObjectsResponse PrepareBuilder()
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

			public override CCSingleBuyObjectsResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleBuyObjectsResponse other)
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
		}

		private static readonly CCSingleBuyObjectsResponse defaultInstance;

		private static readonly string[] _cCSingleBuyObjectsResponseFieldNames;

		private static readonly uint[] _cCSingleBuyObjectsResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int BuyTypeFieldNumber = 6;

		private bool hasBuyType;

		private int buyType_;

		public const int LevelIdFieldNumber = 3;

		private bool hasLevelId;

		private int levelId_;

		public const int BuyTimesFieldNumber = 4;

		private bool hasBuyTimes;

		private int buyTimes_;

		public const int PlayerFieldNumber = 5;

		private bool hasPlayer;

		private CCPlayer player_;

		private int memoizedSerializedSize;

		public static CCSingleBuyObjectsResponse DefaultInstance => null;

		public override CCSingleBuyObjectsResponse DefaultInstanceForType => null;

		protected override CCSingleBuyObjectsResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasBuyType => false;

		public int BuyType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasBuyTimes => false;

		public int BuyTimes => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleBuyObjectsResponse()
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

		public static CCSingleBuyObjectsResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleBuyObjectsResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleBuyObjectsResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleBuyObjectsResponse prototype)
		{
			return null;
		}

		static CCSingleBuyObjectsResponse()
		{
		}
	}
}
