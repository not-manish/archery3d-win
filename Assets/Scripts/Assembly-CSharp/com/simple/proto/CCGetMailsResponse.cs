using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetMailsResponse : GeneratedMessageLite<CCGetMailsResponse, CCGetMailsResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetMailsResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetMailsResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetMailsResponse MessageBeingBuilt => null;

			public override CCGetMailsResponse DefaultInstanceForType => null;

			public bool HasResult => false;

			public int Result
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCMailItem> MailItemsList => null;

			public int MailItemsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGetMailsResponse cloneFrom)
			{
			}

			private CCGetMailsResponse PrepareBuilder()
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

			public override CCGetMailsResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetMailsResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public CCMailItem GetMailItems(int index)
			{
				return null;
			}

			public Builder SetMailItems(int index, CCMailItem value)
			{
				return null;
			}

			public Builder SetMailItems(int index, CCMailItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddMailItems(CCMailItem value)
			{
				return null;
			}

			public Builder AddMailItems(CCMailItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeMailItems(IEnumerable<CCMailItem> values)
			{
				return null;
			}

			public Builder ClearMailItems()
			{
				return null;
			}
		}

		private static readonly CCGetMailsResponse defaultInstance;

		private static readonly string[] _cCGetMailsResponseFieldNames;

		private static readonly uint[] _cCGetMailsResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int MailItemsFieldNumber = 2;

		private PopsicleList<CCMailItem> mailItems_;

		private int memoizedSerializedSize;

		public static CCGetMailsResponse DefaultInstance => null;

		public override CCGetMailsResponse DefaultInstanceForType => null;

		protected override CCGetMailsResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public IList<CCMailItem> MailItemsList => null;

		public int MailItemsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetMailsResponse()
		{
		}

		public CCMailItem GetMailItems(int index)
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

		public static CCGetMailsResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetMailsResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetMailsResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetMailsResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetMailsResponse prototype)
		{
			return null;
		}

		static CCGetMailsResponse()
		{
		}
	}
}
