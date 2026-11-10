using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoExtraRequest : GeneratedMessageLite<CCVideoExtraRequest, CCVideoExtraRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoExtraRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoExtraRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoExtraRequest MessageBeingBuilt => null;

			public override CCVideoExtraRequest DefaultInstanceForType => null;

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

			internal Builder(CCVideoExtraRequest cloneFrom)
			{
			}

			private CCVideoExtraRequest PrepareBuilder()
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

			public override CCVideoExtraRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoExtraRequest other)
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

		private static readonly CCVideoExtraRequest defaultInstance;

		private static readonly string[] _cCVideoExtraRequestFieldNames;

		private static readonly uint[] _cCVideoExtraRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCVideoExtraRequest DefaultInstance => null;

		public override CCVideoExtraRequest DefaultInstanceForType => null;

		protected override CCVideoExtraRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoExtraRequest()
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

		public static CCVideoExtraRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoExtraRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoExtraRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoExtraRequest prototype)
		{
			return null;
		}

		static CCVideoExtraRequest()
		{
		}
	}
}
