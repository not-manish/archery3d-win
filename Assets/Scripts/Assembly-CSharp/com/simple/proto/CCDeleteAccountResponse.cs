using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCDeleteAccountResponse : GeneratedMessageLite<CCDeleteAccountResponse, CCDeleteAccountResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCDeleteAccountResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCDeleteAccountResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCDeleteAccountResponse MessageBeingBuilt => null;

			public override CCDeleteAccountResponse DefaultInstanceForType => null;

			public bool HasResult => false;

			public int Result
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

			internal Builder(CCDeleteAccountResponse cloneFrom)
			{
			}

			private CCDeleteAccountResponse PrepareBuilder()
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

			public override CCDeleteAccountResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCDeleteAccountResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}
		}

		private static readonly CCDeleteAccountResponse defaultInstance;

		private static readonly string[] _cCDeleteAccountResponseFieldNames;

		private static readonly uint[] _cCDeleteAccountResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		private int memoizedSerializedSize;

		public static CCDeleteAccountResponse DefaultInstance => null;

		public override CCDeleteAccountResponse DefaultInstanceForType => null;

		protected override CCDeleteAccountResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCDeleteAccountResponse()
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

		public static CCDeleteAccountResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCDeleteAccountResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCDeleteAccountResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCDeleteAccountResponse prototype)
		{
			return null;
		}

		static CCDeleteAccountResponse()
		{
		}
	}
}
