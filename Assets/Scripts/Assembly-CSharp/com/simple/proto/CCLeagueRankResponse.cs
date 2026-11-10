using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLeagueRankResponse : GeneratedMessageLite<CCLeagueRankResponse, CCLeagueRankResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLeagueRankResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCLeagueRankResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLeagueRankResponse MessageBeingBuilt => null;

			public override CCLeagueRankResponse DefaultInstanceForType => null;

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

			public bool HasCurSegment => false;

			public int CurSegment
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCRankItem> ItemsList => null;

			public int ItemsCount => 0;

			public bool HasTimeLeft => false;

			public long TimeLeft
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCLeagueRankResponse cloneFrom)
			{
			}

			private CCLeagueRankResponse PrepareBuilder()
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

			public override CCLeagueRankResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLeagueRankResponse other)
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

			public Builder SetCurSegment(int value)
			{
				return null;
			}

			public Builder ClearCurSegment()
			{
				return null;
			}

			public CCRankItem GetItems(int index)
			{
				return null;
			}

			public Builder SetItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearItems()
			{
				return null;
			}

			public Builder SetTimeLeft(long value)
			{
				return null;
			}

			public Builder ClearTimeLeft()
			{
				return null;
			}
		}

		private static readonly CCLeagueRankResponse defaultInstance;

		private static readonly string[] _cCLeagueRankResponseFieldNames;

		private static readonly uint[] _cCLeagueRankResponseFieldTags;

		public const int IsGetSuccessFieldNumber = 3;

		private bool hasIsGetSuccess;

		private bool isGetSuccess_;

		public const int CurSegmentFieldNumber = 1;

		private bool hasCurSegment;

		private int curSegment_;

		public const int ItemsFieldNumber = 2;

		private PopsicleList<CCRankItem> items_;

		public const int TimeLeftFieldNumber = 4;

		private bool hasTimeLeft;

		private long timeLeft_;

		private int memoizedSerializedSize;

		public static CCLeagueRankResponse DefaultInstance => null;

		public override CCLeagueRankResponse DefaultInstanceForType => null;

		protected override CCLeagueRankResponse ThisMessage => null;

		public bool HasIsGetSuccess => false;

		public bool IsGetSuccess => false;

		public bool HasCurSegment => false;

		public int CurSegment => 0;

		public IList<CCRankItem> ItemsList => null;

		public int ItemsCount => 0;

		public bool HasTimeLeft => false;

		public long TimeLeft => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLeagueRankResponse()
		{
		}

		public CCRankItem GetItems(int index)
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

		public static CCLeagueRankResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLeagueRankResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLeagueRankResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCLeagueRankResponse prototype)
		{
			return null;
		}

		static CCLeagueRankResponse()
		{
		}
	}
}
