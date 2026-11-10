using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCReMatchRequest : GeneratedMessageLite<CCReMatchRequest, CCReMatchRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCReMatchRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCReMatchRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCReMatchRequest MessageBeingBuilt => null;

			public override CCReMatchRequest DefaultInstanceForType => null;

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

			internal Builder(CCReMatchRequest cloneFrom)
			{
			}

			private CCReMatchRequest PrepareBuilder()
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

			public override CCReMatchRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCReMatchRequest other)
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

		private static readonly CCReMatchRequest defaultInstance;

		private static readonly string[] _cCReMatchRequestFieldNames;

		private static readonly uint[] _cCReMatchRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		private int memoizedSerializedSize;

		public static CCReMatchRequest DefaultInstance => null;

		public override CCReMatchRequest DefaultInstanceForType => null;

		protected override CCReMatchRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCReMatchRequest()
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

		public static CCReMatchRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCReMatchRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCReMatchRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCReMatchRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCReMatchRequest prototype)
		{
			return null;
		}

		static CCReMatchRequest()
		{
		}
	}
}
