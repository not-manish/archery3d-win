using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCUpdateShopRequest : GeneratedMessageLite<CCUpdateShopRequest, CCUpdateShopRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCUpdateShopRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCUpdateShopRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCUpdateShopRequest MessageBeingBuilt => null;

			public override CCUpdateShopRequest DefaultInstanceForType => null;

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

			internal Builder(CCUpdateShopRequest cloneFrom)
			{
			}

			private CCUpdateShopRequest PrepareBuilder()
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

			public override CCUpdateShopRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCUpdateShopRequest other)
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

		private static readonly CCUpdateShopRequest defaultInstance;

		private static readonly string[] _cCUpdateShopRequestFieldNames;

		private static readonly uint[] _cCUpdateShopRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCUpdateShopRequest DefaultInstance => null;

		public override CCUpdateShopRequest DefaultInstanceForType => null;

		protected override CCUpdateShopRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCUpdateShopRequest()
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

		public static CCUpdateShopRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCUpdateShopRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCUpdateShopRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCUpdateShopRequest prototype)
		{
			return null;
		}

		static CCUpdateShopRequest()
		{
		}
	}
}
