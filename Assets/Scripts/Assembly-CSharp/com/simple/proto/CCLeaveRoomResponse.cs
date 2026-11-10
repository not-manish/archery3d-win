using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLeaveRoomResponse : GeneratedMessageLite<CCLeaveRoomResponse, CCLeaveRoomResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLeaveRoomResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCLeaveRoomResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLeaveRoomResponse MessageBeingBuilt => null;

			public override CCLeaveRoomResponse DefaultInstanceForType => null;

			public bool HasStatus => false;

			public CCStatus Status
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

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

			public bool HasRoomState => false;

			public int RoomState
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

			internal Builder(CCLeaveRoomResponse cloneFrom)
			{
			}

			private CCLeaveRoomResponse PrepareBuilder()
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

			public override CCLeaveRoomResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLeaveRoomResponse other)
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

			public Builder SetStatus(CCStatus value)
			{
				return null;
			}

			public Builder SetStatus(CCStatus.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStatus(CCStatus value)
			{
				return null;
			}

			public Builder ClearStatus()
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

			public Builder SetRoomState(int value)
			{
				return null;
			}

			public Builder ClearRoomState()
			{
				return null;
			}
		}

		private static readonly CCLeaveRoomResponse defaultInstance;

		private static readonly string[] _cCLeaveRoomResponseFieldNames;

		private static readonly uint[] _cCLeaveRoomResponseFieldTags;

		public const int StatusFieldNumber = 1;

		private bool hasStatus;

		private CCStatus status_;

		public const int UserIdFieldNumber = 2;

		private bool hasUserId;

		private string userId_;

		public const int RoomStateFieldNumber = 3;

		private bool hasRoomState;

		private int roomState_;

		private int memoizedSerializedSize;

		public static CCLeaveRoomResponse DefaultInstance => null;

		public override CCLeaveRoomResponse DefaultInstanceForType => null;

		protected override CCLeaveRoomResponse ThisMessage => null;

		public bool HasStatus => false;

		public CCStatus Status => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasRoomState => false;

		public int RoomState => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLeaveRoomResponse()
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

		public static CCLeaveRoomResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLeaveRoomResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLeaveRoomResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCLeaveRoomResponse prototype)
		{
			return null;
		}

		static CCLeaveRoomResponse()
		{
		}
	}
}
