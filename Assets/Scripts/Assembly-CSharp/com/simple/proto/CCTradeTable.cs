using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTradeTable : GeneratedMessageLite<CCTradeTable, CCTradeTable.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTradeTable, Builder>
		{
			private bool resultIsReadOnly;

			private CCTradeTable result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTradeTable MessageBeingBuilt => null;

			public override CCTradeTable DefaultInstanceForType => null;

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

			public bool HasTimeMil => false;

			public long TimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasTradeEvent => false;

			public int TradeEvent
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTradeCostGet => false;

			public int TradeCostGet
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTradeGrade => false;

			public int TradeGrade
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTradeCup => false;

			public int TradeCup
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTradeCoin => false;

			public int TradeCoin
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTradeGem => false;

			public int TradeGem
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBigType => false;

			public int BigType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBigId => false;

			public int BigId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBigNum => false;

			public int BigNum
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCTradeItem> SubItemsList => null;

			public int SubItemsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCTradeTable cloneFrom)
			{
			}

			private CCTradeTable PrepareBuilder()
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

			public override CCTradeTable BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTradeTable other)
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

			public Builder SetTimeMil(long value)
			{
				return null;
			}

			public Builder ClearTimeMil()
			{
				return null;
			}

			public Builder SetTradeEvent(int value)
			{
				return null;
			}

			public Builder ClearTradeEvent()
			{
				return null;
			}

			public Builder SetTradeCostGet(int value)
			{
				return null;
			}

			public Builder ClearTradeCostGet()
			{
				return null;
			}

			public Builder SetTradeGrade(int value)
			{
				return null;
			}

			public Builder ClearTradeGrade()
			{
				return null;
			}

			public Builder SetTradeCup(int value)
			{
				return null;
			}

			public Builder ClearTradeCup()
			{
				return null;
			}

			public Builder SetTradeCoin(int value)
			{
				return null;
			}

			public Builder ClearTradeCoin()
			{
				return null;
			}

			public Builder SetTradeGem(int value)
			{
				return null;
			}

			public Builder ClearTradeGem()
			{
				return null;
			}

			public Builder SetBigType(int value)
			{
				return null;
			}

			public Builder ClearBigType()
			{
				return null;
			}

			public Builder SetBigId(int value)
			{
				return null;
			}

			public Builder ClearBigId()
			{
				return null;
			}

			public Builder SetBigNum(int value)
			{
				return null;
			}

			public Builder ClearBigNum()
			{
				return null;
			}

			public CCTradeItem GetSubItems(int index)
			{
				return null;
			}

			public Builder SetSubItems(int index, CCTradeItem value)
			{
				return null;
			}

			public Builder SetSubItems(int index, CCTradeItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddSubItems(CCTradeItem value)
			{
				return null;
			}

			public Builder AddSubItems(CCTradeItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeSubItems(IEnumerable<CCTradeItem> values)
			{
				return null;
			}

			public Builder ClearSubItems()
			{
				return null;
			}
		}

		private static readonly CCTradeTable defaultInstance;

		private static readonly string[] _cCTradeTableFieldNames;

		private static readonly uint[] _cCTradeTableFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int TimeMilFieldNumber = 2;

		private bool hasTimeMil;

		private long timeMil_;

		public const int TradeEventFieldNumber = 3;

		private bool hasTradeEvent;

		private int tradeEvent_;

		public const int TradeCostGetFieldNumber = 4;

		private bool hasTradeCostGet;

		private int tradeCostGet_;

		public const int TradeGradeFieldNumber = 5;

		private bool hasTradeGrade;

		private int tradeGrade_;

		public const int TradeCupFieldNumber = 6;

		private bool hasTradeCup;

		private int tradeCup_;

		public const int TradeCoinFieldNumber = 7;

		private bool hasTradeCoin;

		private int tradeCoin_;

		public const int TradeGemFieldNumber = 8;

		private bool hasTradeGem;

		private int tradeGem_;

		public const int BigTypeFieldNumber = 9;

		private bool hasBigType;

		private int bigType_;

		public const int BigIdFieldNumber = 10;

		private bool hasBigId;

		private int bigId_;

		public const int BigNumFieldNumber = 11;

		private bool hasBigNum;

		private int bigNum_;

		public const int SubItemsFieldNumber = 12;

		private PopsicleList<CCTradeItem> subItems_;

		private int memoizedSerializedSize;

		public static CCTradeTable DefaultInstance => null;

		public override CCTradeTable DefaultInstanceForType => null;

		protected override CCTradeTable ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasTimeMil => false;

		public long TimeMil => 0L;

		public bool HasTradeEvent => false;

		public int TradeEvent => 0;

		public bool HasTradeCostGet => false;

		public int TradeCostGet => 0;

		public bool HasTradeGrade => false;

		public int TradeGrade => 0;

		public bool HasTradeCup => false;

		public int TradeCup => 0;

		public bool HasTradeCoin => false;

		public int TradeCoin => 0;

		public bool HasTradeGem => false;

		public int TradeGem => 0;

		public bool HasBigType => false;

		public int BigType => 0;

		public bool HasBigId => false;

		public int BigId => 0;

		public bool HasBigNum => false;

		public int BigNum => 0;

		public IList<CCTradeItem> SubItemsList => null;

		public int SubItemsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTradeTable()
		{
		}

		public CCTradeItem GetSubItems(int index)
		{
			return null;
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

		public static CCTradeTable ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeTable ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTradeTable ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTradeTable ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTradeTable MakeReadOnly()
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

		public static Builder CreateBuilder(CCTradeTable prototype)
		{
			return null;
		}

		static CCTradeTable()
		{
		}
	}
}
