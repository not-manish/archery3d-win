using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLinkThirdAccountRequest : GeneratedMessageLite<CCLinkThirdAccountRequest, CCLinkThirdAccountRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLinkThirdAccountRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCLinkThirdAccountRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLinkThirdAccountRequest MessageBeingBuilt => null;

			public override CCLinkThirdAccountRequest DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCLinkThirdAccountRequest cloneFrom)
			{
			}

			private CCLinkThirdAccountRequest PrepareBuilder()
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

			public override CCLinkThirdAccountRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLinkThirdAccountRequest other)
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
		}

		private static readonly CCLinkThirdAccountRequest defaultInstance;

		private static readonly string[] _cCLinkThirdAccountRequestFieldNames;

		private static readonly uint[] _cCLinkThirdAccountRequestFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		private int memoizedSerializedSize;

		public static CCLinkThirdAccountRequest DefaultInstance => null;

		public override CCLinkThirdAccountRequest DefaultInstanceForType => null;

		protected override CCLinkThirdAccountRequest ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLinkThirdAccountRequest()
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

		public static CCLinkThirdAccountRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLinkThirdAccountRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLinkThirdAccountRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCLinkThirdAccountRequest prototype)
		{
			return null;
		}

		static CCLinkThirdAccountRequest()
		{
		}
	}
}
