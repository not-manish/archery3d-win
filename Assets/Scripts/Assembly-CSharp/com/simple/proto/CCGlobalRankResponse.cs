using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGlobalRankResponse : GeneratedMessageLite<CCGlobalRankResponse, CCGlobalRankResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGlobalRankResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGlobalRankResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGlobalRankResponse MessageBeingBuilt => null;

			public override CCGlobalRankResponse DefaultInstanceForType => null;

			public bool HasIsGetSuccess => false;

			public bool IsGetSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlayersAllCount => false;

			public long PlayersAllCount
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasMyTrophy => false;

			public long MyTrophy
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public IPopsicleList<CCRankItem> Top50ItemsList => null;

			public int Top50ItemsCount => 0;

			public IPopsicleList<CCRankItem> FrontItemsList => null;

			public int FrontItemsCount => 0;

			public IPopsicleList<CCRankItem> BackItemsList => null;

			public int BackItemsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGlobalRankResponse cloneFrom)
			{
			}

			private CCGlobalRankResponse PrepareBuilder()
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

			public override CCGlobalRankResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGlobalRankResponse other)
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

			public Builder SetIsGetSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsGetSuccess()
			{
				return null;
			}

			public Builder SetPlayersAllCount(long value)
			{
				return null;
			}

			public Builder ClearPlayersAllCount()
			{
				return null;
			}

			public Builder SetMyTrophy(long value)
			{
				return null;
			}

			public Builder ClearMyTrophy()
			{
				return null;
			}

			public CCRankItem GetTop50Items(int index)
			{
				return null;
			}

			public Builder SetTop50Items(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetTop50Items(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddTop50Items(CCRankItem value)
			{
				return null;
			}

			public Builder AddTop50Items(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeTop50Items(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearTop50Items()
			{
				return null;
			}

			public CCRankItem GetFrontItems(int index)
			{
				return null;
			}

			public Builder SetFrontItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetFrontItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFrontItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddFrontItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFrontItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearFrontItems()
			{
				return null;
			}

			public CCRankItem GetBackItems(int index)
			{
				return null;
			}

			public Builder SetBackItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetBackItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddBackItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddBackItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeBackItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearBackItems()
			{
				return null;
			}
		}

		private static readonly CCGlobalRankResponse defaultInstance;

		private static readonly string[] _cCGlobalRankResponseFieldNames;

		private static readonly uint[] _cCGlobalRankResponseFieldTags;

		public const int IsGetSuccessFieldNumber = 1;

		private bool hasIsGetSuccess;

		private bool isGetSuccess_;

		public const int PlayersAllCountFieldNumber = 2;

		private bool hasPlayersAllCount;

		private long playersAllCount_;

		public const int MyTrophyFieldNumber = 3;

		private bool hasMyTrophy;

		private long myTrophy_;

		public const int Top50ItemsFieldNumber = 4;

		private PopsicleList<CCRankItem> top50Items_;

		public const int FrontItemsFieldNumber = 5;

		private PopsicleList<CCRankItem> frontItems_;

		public const int BackItemsFieldNumber = 6;

		private PopsicleList<CCRankItem> backItems_;

		private int memoizedSerializedSize;

		public static CCGlobalRankResponse DefaultInstance => null;

		public override CCGlobalRankResponse DefaultInstanceForType => null;

		protected override CCGlobalRankResponse ThisMessage => null;

		public bool HasIsGetSuccess => false;

		public bool IsGetSuccess => false;

		public bool HasPlayersAllCount => false;

		public long PlayersAllCount => 0L;

		public bool HasMyTrophy => false;

		public long MyTrophy => 0L;

		public IList<CCRankItem> Top50ItemsList => null;

		public int Top50ItemsCount => 0;

		public IList<CCRankItem> FrontItemsList => null;

		public int FrontItemsCount => 0;

		public IList<CCRankItem> BackItemsList => null;

		public int BackItemsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGlobalRankResponse()
		{
		}

		public CCRankItem GetTop50Items(int index)
		{
			return null;
		}

		public CCRankItem GetFrontItems(int index)
		{
			return null;
		}

		public CCRankItem GetBackItems(int index)
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

		public static CCGlobalRankResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGlobalRankResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGlobalRankResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGlobalRankResponse prototype)
		{
			return null;
		}

		static CCGlobalRankResponse()
		{
		}
	}
}
