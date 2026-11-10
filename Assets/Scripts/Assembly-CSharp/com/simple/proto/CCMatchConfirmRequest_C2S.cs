using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCMatchConfirmRequest_C2S : GeneratedMessageLite<CCMatchConfirmRequest_C2S, CCMatchConfirmRequest_C2S.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCMatchConfirmRequest_C2S, Builder>
		{
			private bool resultIsReadOnly;

			private CCMatchConfirmRequest_C2S result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCMatchConfirmRequest_C2S MessageBeingBuilt => null;

			public override CCMatchConfirmRequest_C2S DefaultInstanceForType => null;

			public bool HasUserId => false;

			public string UserId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasIsConfirmSuccess => false;

			public bool IsConfirmSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCMatchConfirmRequest_C2S cloneFrom)
			{
			}

			private CCMatchConfirmRequest_C2S PrepareBuilder()
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

			public override CCMatchConfirmRequest_C2S BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCMatchConfirmRequest_C2S other)
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

			public Builder SetUserId(string value)
			{
				return null;
			}

			public Builder ClearUserId()
			{
				return null;
			}

			public Builder SetIsConfirmSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsConfirmSuccess()
			{
				return null;
			}
		}

		private static readonly CCMatchConfirmRequest_C2S defaultInstance;

		private static readonly string[] _cCMatchConfirmRequestC2SFieldNames;

		private static readonly uint[] _cCMatchConfirmRequestC2SFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int IsConfirmSuccessFieldNumber = 2;

		private bool hasIsConfirmSuccess;

		private bool isConfirmSuccess_;

		private int memoizedSerializedSize;

		public static CCMatchConfirmRequest_C2S DefaultInstance => null;

		public override CCMatchConfirmRequest_C2S DefaultInstanceForType => null;

		protected override CCMatchConfirmRequest_C2S ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasIsConfirmSuccess => false;

		public bool IsConfirmSuccess => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCMatchConfirmRequest_C2S()
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

		public static CCMatchConfirmRequest_C2S ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(Stream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_C2S ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCMatchConfirmRequest_C2S MakeReadOnly()
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

		public static Builder CreateBuilder(CCMatchConfirmRequest_C2S prototype)
		{
			return null;
		}

		static CCMatchConfirmRequest_C2S()
		{
		}
	}
}
