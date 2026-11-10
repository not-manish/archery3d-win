using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGlobalRankRequest : GeneratedMessageLite<CCGlobalRankRequest, CCGlobalRankRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGlobalRankRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGlobalRankRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGlobalRankRequest MessageBeingBuilt => null;

			public override CCGlobalRankRequest DefaultInstanceForType => null;

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

			internal Builder(CCGlobalRankRequest cloneFrom)
			{
			}

			private CCGlobalRankRequest PrepareBuilder()
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

			public override CCGlobalRankRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGlobalRankRequest other)
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

		private static readonly CCGlobalRankRequest defaultInstance;

		private static readonly string[] _cCGlobalRankRequestFieldNames;

		private static readonly uint[] _cCGlobalRankRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCGlobalRankRequest DefaultInstance => null;

		public override CCGlobalRankRequest DefaultInstanceForType => null;

		protected override CCGlobalRankRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGlobalRankRequest()
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

		public static CCGlobalRankRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGlobalRankRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGlobalRankRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGlobalRankRequest prototype)
		{
			return null;
		}

		static CCGlobalRankRequest()
		{
		}
	}
}
