using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTradeItem : GeneratedMessageLite<CCTradeItem, CCTradeItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTradeItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCTradeItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTradeItem MessageBeingBuilt => null;

			public override CCTradeItem DefaultInstanceForType => null;

			public bool HasSubType => false;

			public int SubType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSubId => false;

			public int SubId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSubNum => false;

			public int SubNum
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

			internal Builder(CCTradeItem cloneFrom)
			{
			}

			private CCTradeItem PrepareBuilder()
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

			public override CCTradeItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTradeItem other)
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

			public Builder SetSubType(int value)
			{
				return null;
			}

			public Builder ClearSubType()
			{
				return null;
			}

			public Builder SetSubId(int value)
			{
				return null;
			}

			public Builder ClearSubId()
			{
				return null;
			}

			public Builder SetSubNum(int value)
			{
				return null;
			}

			public Builder ClearSubNum()
			{
				return null;
			}
		}

		private static readonly CCTradeItem defaultInstance;

		private static readonly string[] _cCTradeItemFieldNames;

		private static readonly uint[] _cCTradeItemFieldTags;

		public const int SubTypeFieldNumber = 1;

		private bool hasSubType;

		private int subType_;

		public const int SubIdFieldNumber = 2;

		private bool hasSubId;

		private int subId_;

		public const int SubNumFieldNumber = 3;

		private bool hasSubNum;

		private int subNum_;

		private int memoizedSerializedSize;

		public static CCTradeItem DefaultInstance => null;

		public override CCTradeItem DefaultInstanceForType => null;

		protected override CCTradeItem ThisMessage => null;

		public bool HasSubType => false;

		public int SubType => 0;

		public bool HasSubId => false;

		public int SubId => 0;

		public bool HasSubNum => false;

		public int SubNum => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTradeItem()
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

		public static CCTradeItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTradeItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTradeItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTradeItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCTradeItem prototype)
		{
			return null;
		}

		static CCTradeItem()
		{
		}
	}
}
