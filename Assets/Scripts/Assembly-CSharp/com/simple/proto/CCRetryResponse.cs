using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRetryResponse : GeneratedMessageLite<CCRetryResponse, CCRetryResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRetryResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCRetryResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRetryResponse MessageBeingBuilt => null;

			public override CCRetryResponse DefaultInstanceForType => null;

			public bool HasRetrySuccess => false;

			public bool RetrySuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCRetryResponse cloneFrom)
			{
			}

			private CCRetryResponse PrepareBuilder()
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

			public override CCRetryResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRetryResponse other)
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

			public Builder SetRetrySuccess(bool value)
			{
				return null;
			}

			public Builder ClearRetrySuccess()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
			{
				return null;
			}
		}

		private static readonly CCRetryResponse defaultInstance;

		private static readonly string[] _cCRetryResponseFieldNames;

		private static readonly uint[] _cCRetryResponseFieldTags;

		public const int RetrySuccessFieldNumber = 1;

		private bool hasRetrySuccess;

		private bool retrySuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		private int memoizedSerializedSize;

		public static CCRetryResponse DefaultInstance => null;

		public override CCRetryResponse DefaultInstanceForType => null;

		protected override CCRetryResponse ThisMessage => null;

		public bool HasRetrySuccess => false;

		public bool RetrySuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRetryResponse()
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

		public static CCRetryResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRetryResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRetryResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRetryResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCRetryResponse prototype)
		{
			return null;
		}

		static CCRetryResponse()
		{
		}
	}
}
