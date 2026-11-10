using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTradeRequest : GeneratedMessageLite<CCTradeRequest, CCTradeRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTradeRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCTradeRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTradeRequest MessageBeingBuilt => null;

			public override CCTradeRequest DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCTradeRequest cloneFrom)
			{
			}

			private CCTradeRequest PrepareBuilder()
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

			public override CCTradeRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTradeRequest other)
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
		}

		private static readonly CCTradeRequest defaultInstance;

		private static readonly string[] _cCTradeRequestFieldNames;

		private static readonly uint[] _cCTradeRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCTradeRequest DefaultInstance => null;

		public override CCTradeRequest DefaultInstanceForType => null;

		protected override CCTradeRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTradeRequest()
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

		public static CCTradeRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTradeRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTradeRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTradeRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCTradeRequest prototype)
		{
			return null;
		}

		static CCTradeRequest()
		{
		}
	}
}
