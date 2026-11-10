using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTradeReponse : GeneratedMessageLite<CCTradeReponse, CCTradeReponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTradeReponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCTradeReponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTradeReponse MessageBeingBuilt => null;

			public override CCTradeReponse DefaultInstanceForType => null;

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

			public IPopsicleList<CCTradeTable> ItemsList => null;

			public int ItemsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCTradeReponse cloneFrom)
			{
			}

			private CCTradeReponse PrepareBuilder()
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

			public override CCTradeReponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTradeReponse other)
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

			public CCTradeTable GetItems(int index)
			{
				return null;
			}

			public Builder SetItems(int index, CCTradeTable value)
			{
				return null;
			}

			public Builder SetItems(int index, CCTradeTable.Builder builderForValue)
			{
				return null;
			}

			public Builder AddItems(CCTradeTable value)
			{
				return null;
			}

			public Builder AddItems(CCTradeTable.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeItems(IEnumerable<CCTradeTable> values)
			{
				return null;
			}

			public Builder ClearItems()
			{
				return null;
			}
		}

		private static readonly CCTradeReponse defaultInstance;

		private static readonly string[] _cCTradeReponseFieldNames;

		private static readonly uint[] _cCTradeReponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ItemsFieldNumber = 2;

		private PopsicleList<CCTradeTable> items_;

		private int memoizedSerializedSize;

		public static CCTradeReponse DefaultInstance => null;

		public override CCTradeReponse DefaultInstanceForType => null;

		protected override CCTradeReponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public IList<CCTradeTable> ItemsList => null;

		public int ItemsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTradeReponse()
		{
		}

		public CCTradeTable GetItems(int index)
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

		public static CCTradeReponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeReponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTradeReponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTradeReponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTradeReponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCTradeReponse prototype)
		{
			return null;
		}

		static CCTradeReponse()
		{
		}
	}
}
