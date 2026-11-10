using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCWatchVideoSuccessRequest : GeneratedMessageLite<CCWatchVideoSuccessRequest, CCWatchVideoSuccessRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCWatchVideoSuccessRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCWatchVideoSuccessRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCWatchVideoSuccessRequest MessageBeingBuilt => null;

			public override CCWatchVideoSuccessRequest DefaultInstanceForType => null;

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

			internal Builder(CCWatchVideoSuccessRequest cloneFrom)
			{
			}

			private CCWatchVideoSuccessRequest PrepareBuilder()
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

			public override CCWatchVideoSuccessRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCWatchVideoSuccessRequest other)
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

		private static readonly CCWatchVideoSuccessRequest defaultInstance;

		private static readonly string[] _cCWatchVideoSuccessRequestFieldNames;

		private static readonly uint[] _cCWatchVideoSuccessRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCWatchVideoSuccessRequest DefaultInstance => null;

		public override CCWatchVideoSuccessRequest DefaultInstanceForType => null;

		protected override CCWatchVideoSuccessRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCWatchVideoSuccessRequest()
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

		public static CCWatchVideoSuccessRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCWatchVideoSuccessRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCWatchVideoSuccessRequest prototype)
		{
			return null;
		}

		static CCWatchVideoSuccessRequest()
		{
		}
	}
}
