using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayAgainRequest : GeneratedMessageLite<CCPlayAgainRequest, CCPlayAgainRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayAgainRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayAgainRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayAgainRequest MessageBeingBuilt => null;

			public override CCPlayAgainRequest DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCPlayAgainRequest cloneFrom)
			{
			}

			private CCPlayAgainRequest PrepareBuilder()
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

			public override CCPlayAgainRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayAgainRequest other)
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
		}

		private static readonly CCPlayAgainRequest defaultInstance;

		private static readonly string[] _cCPlayAgainRequestFieldNames;

		private static readonly uint[] _cCPlayAgainRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		private int memoizedSerializedSize;

		public static CCPlayAgainRequest DefaultInstance => null;

		public override CCPlayAgainRequest DefaultInstanceForType => null;

		protected override CCPlayAgainRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayAgainRequest()
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

		public static CCPlayAgainRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayAgainRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayAgainRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayAgainRequest prototype)
		{
			return null;
		}

		static CCPlayAgainRequest()
		{
		}
	}
}
