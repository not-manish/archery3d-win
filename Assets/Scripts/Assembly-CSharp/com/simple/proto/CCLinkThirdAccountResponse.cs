using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLinkThirdAccountResponse : GeneratedMessageLite<CCLinkThirdAccountResponse, CCLinkThirdAccountResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLinkThirdAccountResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCLinkThirdAccountResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLinkThirdAccountResponse MessageBeingBuilt => null;

			public override CCLinkThirdAccountResponse DefaultInstanceForType => null;

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

			public bool HasItem => false;

			public CCThirdAccountItem Item
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasAccount => false;

			public CCUserAccount Account
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

			internal Builder(CCLinkThirdAccountResponse cloneFrom)
			{
			}

			private CCLinkThirdAccountResponse PrepareBuilder()
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

			public override CCLinkThirdAccountResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLinkThirdAccountResponse other)
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

			public Builder SetItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder SetItem(CCThirdAccountItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder ClearItem()
			{
				return null;
			}

			public Builder SetAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder SetAccount(CCUserAccount.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder ClearAccount()
			{
				return null;
			}
		}

		private static readonly CCLinkThirdAccountResponse defaultInstance;

		private static readonly string[] _cCLinkThirdAccountResponseFieldNames;

		private static readonly uint[] _cCLinkThirdAccountResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		public const int AccountFieldNumber = 3;

		private bool hasAccount;

		private CCUserAccount account_;

		private int memoizedSerializedSize;

		public static CCLinkThirdAccountResponse DefaultInstance => null;

		public override CCLinkThirdAccountResponse DefaultInstanceForType => null;

		protected override CCLinkThirdAccountResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public bool HasAccount => false;

		public CCUserAccount Account => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLinkThirdAccountResponse()
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

		public static CCLinkThirdAccountResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLinkThirdAccountResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLinkThirdAccountResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCLinkThirdAccountResponse prototype)
		{
			return null;
		}

		static CCLinkThirdAccountResponse()
		{
		}
	}
}
