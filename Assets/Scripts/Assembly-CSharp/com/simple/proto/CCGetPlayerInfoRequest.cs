using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetPlayerInfoRequest : GeneratedMessageLite<CCGetPlayerInfoRequest, CCGetPlayerInfoRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetPlayerInfoRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetPlayerInfoRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetPlayerInfoRequest MessageBeingBuilt => null;

			public override CCGetPlayerInfoRequest DefaultInstanceForType => null;

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

			internal Builder(CCGetPlayerInfoRequest cloneFrom)
			{
			}

			private CCGetPlayerInfoRequest PrepareBuilder()
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

			public override CCGetPlayerInfoRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetPlayerInfoRequest other)
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

		private static readonly CCGetPlayerInfoRequest defaultInstance;

		private static readonly string[] _cCGetPlayerInfoRequestFieldNames;

		private static readonly uint[] _cCGetPlayerInfoRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCGetPlayerInfoRequest DefaultInstance => null;

		public override CCGetPlayerInfoRequest DefaultInstanceForType => null;

		protected override CCGetPlayerInfoRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetPlayerInfoRequest()
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

		public static CCGetPlayerInfoRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetPlayerInfoRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetPlayerInfoRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetPlayerInfoRequest prototype)
		{
			return null;
		}

		static CCGetPlayerInfoRequest()
		{
		}
	}
}
