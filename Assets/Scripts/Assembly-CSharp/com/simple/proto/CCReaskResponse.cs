using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCReaskResponse : GeneratedMessageLite<CCReaskResponse, CCReaskResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCReaskResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCReaskResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCReaskResponse MessageBeingBuilt => null;

			public override CCReaskResponse DefaultInstanceForType => null;

			public bool HasAskResType => false;

			public int AskResType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAskSuccess => false;

			public bool AskSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCReaskResponse cloneFrom)
			{
			}

			private CCReaskResponse PrepareBuilder()
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

			public override CCReaskResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCReaskResponse other)
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

			public Builder SetAskResType(int value)
			{
				return null;
			}

			public Builder ClearAskResType()
			{
				return null;
			}

			public Builder SetAskSuccess(bool value)
			{
				return null;
			}

			public Builder ClearAskSuccess()
			{
				return null;
			}
		}

		private static readonly CCReaskResponse defaultInstance;

		private static readonly string[] _cCReaskResponseFieldNames;

		private static readonly uint[] _cCReaskResponseFieldTags;

		public const int AskResTypeFieldNumber = 1;

		private bool hasAskResType;

		private int askResType_;

		public const int AskSuccessFieldNumber = 2;

		private bool hasAskSuccess;

		private bool askSuccess_;

		private int memoizedSerializedSize;

		public static CCReaskResponse DefaultInstance => null;

		public override CCReaskResponse DefaultInstanceForType => null;

		protected override CCReaskResponse ThisMessage => null;

		public bool HasAskResType => false;

		public int AskResType => 0;

		public bool HasAskSuccess => false;

		public bool AskSuccess => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCReaskResponse()
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

		public static CCReaskResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCReaskResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCReaskResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCReaskResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCReaskResponse prototype)
		{
			return null;
		}

		static CCReaskResponse()
		{
		}
	}
}
