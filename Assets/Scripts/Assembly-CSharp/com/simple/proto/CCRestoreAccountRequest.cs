using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRestoreAccountRequest : GeneratedMessageLite<CCRestoreAccountRequest, CCRestoreAccountRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRestoreAccountRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCRestoreAccountRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRestoreAccountRequest MessageBeingBuilt => null;

			public override CCRestoreAccountRequest DefaultInstanceForType => null;

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

			internal Builder(CCRestoreAccountRequest cloneFrom)
			{
			}

			private CCRestoreAccountRequest PrepareBuilder()
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

			public override CCRestoreAccountRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRestoreAccountRequest other)
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

		private static readonly CCRestoreAccountRequest defaultInstance;

		private static readonly string[] _cCRestoreAccountRequestFieldNames;

		private static readonly uint[] _cCRestoreAccountRequestFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		private int memoizedSerializedSize;

		public static CCRestoreAccountRequest DefaultInstance => null;

		public override CCRestoreAccountRequest DefaultInstanceForType => null;

		protected override CCRestoreAccountRequest ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRestoreAccountRequest()
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

		public static CCRestoreAccountRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRestoreAccountRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRestoreAccountRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCRestoreAccountRequest prototype)
		{
			return null;
		}

		static CCRestoreAccountRequest()
		{
		}
	}
}
