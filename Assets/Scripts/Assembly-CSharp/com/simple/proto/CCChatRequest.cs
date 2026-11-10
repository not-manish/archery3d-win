using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChatRequest : GeneratedMessageLite<CCChatRequest, CCChatRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChatRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChatRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChatRequest MessageBeingBuilt => null;

			public override CCChatRequest DefaultInstanceForType => null;

			public bool HasUserId => false;

			public string UserId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

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

			internal Builder(CCChatRequest cloneFrom)
			{
			}

			private CCChatRequest PrepareBuilder()
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

			public override CCChatRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChatRequest other)
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

			public Builder SetUserId(string value)
			{
				return null;
			}

			public Builder ClearUserId()
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

		private static readonly CCChatRequest defaultInstance;

		private static readonly string[] _cCChatRequestFieldNames;

		private static readonly uint[] _cCChatRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int ChatIdFieldNumber = 2;

		private bool hasChatId;

		private int chatId_;

		private int memoizedSerializedSize;

		public static CCChatRequest DefaultInstance => null;

		public override CCChatRequest DefaultInstanceForType => null;

		protected override CCChatRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasChatId => false;

		public int ChatId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChatRequest()
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

		public static CCChatRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChatRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChatRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChatRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChatRequest prototype)
		{
			return null;
		}

		static CCChatRequest()
		{
		}
	}
}
