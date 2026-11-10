using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCHeartbeatResponse : GeneratedMessageLite<CCHeartbeatResponse, CCHeartbeatResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCHeartbeatResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCHeartbeatResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCHeartbeatResponse MessageBeingBuilt => null;

			public override CCHeartbeatResponse DefaultInstanceForType => null;

			public bool HasCurTimestamp => false;

			public long CurTimestamp
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

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

			internal Builder(CCHeartbeatResponse cloneFrom)
			{
			}

			private CCHeartbeatResponse PrepareBuilder()
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

			public override CCHeartbeatResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCHeartbeatResponse other)
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

			public Builder SetCurTimestamp(long value)
			{
				return null;
			}

			public Builder ClearCurTimestamp()
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

		private static readonly CCHeartbeatResponse defaultInstance;

		private static readonly string[] _cCHeartbeatResponseFieldNames;

		private static readonly uint[] _cCHeartbeatResponseFieldTags;

		public const int CurTimestampFieldNumber = 1;

		private bool hasCurTimestamp;

		private long curTimestamp_;

		public const int RequestTimeFieldNumber = 2;

		private bool hasRequestTime;

		private long requestTime_;

		private int memoizedSerializedSize;

		public static CCHeartbeatResponse DefaultInstance => null;

		public override CCHeartbeatResponse DefaultInstanceForType => null;

		protected override CCHeartbeatResponse ThisMessage => null;

		public bool HasCurTimestamp => false;

		public long CurTimestamp => 0L;

		public bool HasRequestTime => false;

		public long RequestTime => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCHeartbeatResponse()
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

		public static CCHeartbeatResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCHeartbeatResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCHeartbeatResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCHeartbeatResponse prototype)
		{
			return null;
		}

		static CCHeartbeatResponse()
		{
		}
	}
}
