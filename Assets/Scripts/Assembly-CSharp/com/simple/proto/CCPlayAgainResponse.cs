using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayAgainResponse : GeneratedMessageLite<CCPlayAgainResponse, CCPlayAgainResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayAgainResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayAgainResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayAgainResponse MessageBeingBuilt => null;

			public override CCPlayAgainResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
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

			internal Builder(CCPlayAgainResponse cloneFrom)
			{
			}

			private CCPlayAgainResponse PrepareBuilder()
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

			public override CCPlayAgainResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayAgainResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
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

		private static readonly CCPlayAgainResponse defaultInstance;

		private static readonly string[] _cCPlayAgainResponseFieldNames;

		private static readonly uint[] _cCPlayAgainResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		private int memoizedSerializedSize;

		public static CCPlayAgainResponse DefaultInstance => null;

		public override CCPlayAgainResponse DefaultInstanceForType => null;

		protected override CCPlayAgainResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayAgainResponse()
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

		public static CCPlayAgainResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayAgainResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayAgainResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayAgainResponse prototype)
		{
			return null;
		}

		static CCPlayAgainResponse()
		{
		}
	}
}
