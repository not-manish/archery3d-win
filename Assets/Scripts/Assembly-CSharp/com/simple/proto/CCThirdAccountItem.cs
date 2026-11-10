using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCThirdAccountItem : GeneratedMessageLite<CCThirdAccountItem, CCThirdAccountItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCThirdAccountItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCThirdAccountItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCThirdAccountItem MessageBeingBuilt => null;

			public override CCThirdAccountItem DefaultInstanceForType => null;

			public bool HasType => false;

			public int Type
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

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

			public bool HasToken => false;

			public string Token
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasName => false;

			public string Name
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

			internal Builder(CCThirdAccountItem cloneFrom)
			{
			}

			private CCThirdAccountItem PrepareBuilder()
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

			public override CCThirdAccountItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCThirdAccountItem other)
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

			public Builder SetType(int value)
			{
				return null;
			}

			public Builder ClearType()
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

			public Builder SetToken(string value)
			{
				return null;
			}

			public Builder ClearToken()
			{
				return null;
			}

			public Builder SetName(string value)
			{
				return null;
			}

			public Builder ClearName()
			{
				return null;
			}
		}

		private static readonly CCThirdAccountItem defaultInstance;

		private static readonly string[] _cCThirdAccountItemFieldNames;

		private static readonly uint[] _cCThirdAccountItemFieldTags;

		public const int TypeFieldNumber = 1;

		private bool hasType;

		private int type_;

		public const int IdFieldNumber = 2;

		private bool hasId;

		private string id_;

		public const int TokenFieldNumber = 3;

		private bool hasToken;

		private string token_;

		public const int NameFieldNumber = 4;

		private bool hasName;

		private string name_;

		private int memoizedSerializedSize;

		public static CCThirdAccountItem DefaultInstance => null;

		public override CCThirdAccountItem DefaultInstanceForType => null;

		protected override CCThirdAccountItem ThisMessage => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasId => false;

		public string Id => null;

		public bool HasToken => false;

		public string Token => null;

		public bool HasName => false;

		public string Name => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCThirdAccountItem()
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

		public static CCThirdAccountItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCThirdAccountItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCThirdAccountItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCThirdAccountItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCThirdAccountItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCThirdAccountItem prototype)
		{
			return null;
		}

		static CCThirdAccountItem()
		{
		}
	}
}
