using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetMailsRequest : GeneratedMessageLite<CCGetMailsRequest, CCGetMailsRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetMailsRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetMailsRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetMailsRequest MessageBeingBuilt => null;

			public override CCGetMailsRequest DefaultInstanceForType => null;

			public bool HasId => false;

			public string Id
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

			internal Builder(CCGetMailsRequest cloneFrom)
			{
			}

			private CCGetMailsRequest PrepareBuilder()
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

			public override CCGetMailsRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetMailsRequest other)
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

			public Builder SetId(string value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}
		}

		private static readonly CCGetMailsRequest defaultInstance;

		private static readonly string[] _cCGetMailsRequestFieldNames;

		private static readonly uint[] _cCGetMailsRequestFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		private int memoizedSerializedSize;

		public static CCGetMailsRequest DefaultInstance => null;

		public override CCGetMailsRequest DefaultInstanceForType => null;

		protected override CCGetMailsRequest ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetMailsRequest()
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

		public static CCGetMailsRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetMailsRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetMailsRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetMailsRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetMailsRequest prototype)
		{
			return null;
		}

		static CCGetMailsRequest()
		{
		}
	}
}
