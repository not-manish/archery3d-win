using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRateRequest : GeneratedMessageLite<CCRateRequest, CCRateRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRateRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCRateRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRateRequest MessageBeingBuilt => null;

			public override CCRateRequest DefaultInstanceForType => null;

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

			internal Builder(CCRateRequest cloneFrom)
			{
			}

			private CCRateRequest PrepareBuilder()
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

			public override CCRateRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRateRequest other)
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

		private static readonly CCRateRequest defaultInstance;

		private static readonly string[] _cCRateRequestFieldNames;

		private static readonly uint[] _cCRateRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCRateRequest DefaultInstance => null;

		public override CCRateRequest DefaultInstanceForType => null;

		protected override CCRateRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRateRequest()
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

		public static CCRateRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRateRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRateRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRateRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRateRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCRateRequest prototype)
		{
			return null;
		}

		static CCRateRequest()
		{
		}
	}
}
