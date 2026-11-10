using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetThirdTokenRequest : GeneratedMessageLite<CCGetThirdTokenRequest, CCGetThirdTokenRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetThirdTokenRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetThirdTokenRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetThirdTokenRequest MessageBeingBuilt => null;

			public override CCGetThirdTokenRequest DefaultInstanceForType => null;

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

			public bool HasIsLink => false;

			public bool IsLink
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

			internal Builder(CCGetThirdTokenRequest cloneFrom)
			{
			}

			private CCGetThirdTokenRequest PrepareBuilder()
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

			public override CCGetThirdTokenRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetThirdTokenRequest other)
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

			public Builder SetIsLink(bool value)
			{
				return null;
			}

			public Builder ClearIsLink()
			{
				return null;
			}
		}

		private static readonly CCGetThirdTokenRequest defaultInstance;

		private static readonly string[] _cCGetThirdTokenRequestFieldNames;

		private static readonly uint[] _cCGetThirdTokenRequestFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		public const int IsLinkFieldNumber = 3;

		private bool hasIsLink;

		private bool isLink_;

		private int memoizedSerializedSize;

		public static CCGetThirdTokenRequest DefaultInstance => null;

		public override CCGetThirdTokenRequest DefaultInstanceForType => null;

		protected override CCGetThirdTokenRequest ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public bool HasIsLink => false;

		public bool IsLink => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetThirdTokenRequest()
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

		public static CCGetThirdTokenRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetThirdTokenRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetThirdTokenRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetThirdTokenRequest prototype)
		{
			return null;
		}

		static CCGetThirdTokenRequest()
		{
		}
	}
}
