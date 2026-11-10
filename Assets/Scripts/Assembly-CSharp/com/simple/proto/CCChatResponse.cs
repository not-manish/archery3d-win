using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChatResponse : GeneratedMessageLite<CCChatResponse, CCChatResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChatResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCChatResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChatResponse MessageBeingBuilt => null;

			public override CCChatResponse DefaultInstanceForType => null;

			public bool HasChatId => false;

			public int ChatId
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

			internal Builder(CCChatResponse cloneFrom)
			{
			}

			private CCChatResponse PrepareBuilder()
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

			public override CCChatResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChatResponse other)
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

			public Builder SetChatId(int value)
			{
				return null;
			}

			public Builder ClearChatId()
			{
				return null;
			}
		}

		private static readonly CCChatResponse defaultInstance;

		private static readonly string[] _cCChatResponseFieldNames;

		private static readonly uint[] _cCChatResponseFieldTags;

		public const int ChatIdFieldNumber = 2;

		private bool hasChatId;

		private int chatId_;

		private int memoizedSerializedSize;

		public static CCChatResponse DefaultInstance => null;

		public override CCChatResponse DefaultInstanceForType => null;

		protected override CCChatResponse ThisMessage => null;

		public bool HasChatId => false;

		public int ChatId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChatResponse()
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

		public static CCChatResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChatResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChatResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChatResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCChatResponse prototype)
		{
			return null;
		}

		static CCChatResponse()
		{
		}
	}
}
