using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCHeartbeatRequest : GeneratedMessageLite<CCHeartbeatRequest, CCHeartbeatRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCHeartbeatRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCHeartbeatRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCHeartbeatRequest MessageBeingBuilt => null;

			public override CCHeartbeatRequest DefaultInstanceForType => null;

			public bool HasRequestTime => false;

			public long RequestTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCHeartbeatRequest cloneFrom)
			{
			}

			private CCHeartbeatRequest PrepareBuilder()
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

			public override CCHeartbeatRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCHeartbeatRequest other)
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

			public Builder SetRequestTime(long value)
			{
				return null;
			}

			public Builder ClearRequestTime()
			{
				return null;
			}
		}

		private static readonly CCHeartbeatRequest defaultInstance;

		private static readonly string[] _cCHeartbeatRequestFieldNames;

		private static readonly uint[] _cCHeartbeatRequestFieldTags;

		public const int RequestTimeFieldNumber = 2;

		private bool hasRequestTime;

		private long requestTime_;

		private int memoizedSerializedSize;

		public static CCHeartbeatRequest DefaultInstance => null;

		public override CCHeartbeatRequest DefaultInstanceForType => null;

		protected override CCHeartbeatRequest ThisMessage => null;

		public bool HasRequestTime => false;

		public long RequestTime => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCHeartbeatRequest()
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

		public static CCHeartbeatRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCHeartbeatRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCHeartbeatRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCHeartbeatRequest prototype)
		{
			return null;
		}

		static CCHeartbeatRequest()
		{
		}
	}
}
