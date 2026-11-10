using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCReaskRequest : GeneratedMessageLite<CCReaskRequest, CCReaskRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCReaskRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCReaskRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCReaskRequest MessageBeingBuilt => null;

			public override CCReaskRequest DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCReaskRequest cloneFrom)
			{
			}

			private CCReaskRequest PrepareBuilder()
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

			public override CCReaskRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCReaskRequest other)
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
		}

		private static readonly CCReaskRequest defaultInstance;

		private static readonly string[] _cCReaskRequestFieldNames;

		private static readonly uint[] _cCReaskRequestFieldTags;

		public const int AskResTypeFieldNumber = 1;

		private bool hasAskResType;

		private int askResType_;

		private int memoizedSerializedSize;

		public static CCReaskRequest DefaultInstance => null;

		public override CCReaskRequest DefaultInstanceForType => null;

		protected override CCReaskRequest ThisMessage => null;

		public bool HasAskResType => false;

		public int AskResType => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCReaskRequest()
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

		public static CCReaskRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCReaskRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCReaskRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCReaskRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCReaskRequest prototype)
		{
			return null;
		}

		static CCReaskRequest()
		{
		}
	}
}
