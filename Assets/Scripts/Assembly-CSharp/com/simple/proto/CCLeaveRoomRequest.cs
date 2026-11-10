using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLeaveRoomRequest : GeneratedMessageLite<CCLeaveRoomRequest, CCLeaveRoomRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLeaveRoomRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCLeaveRoomRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLeaveRoomRequest MessageBeingBuilt => null;

			public override CCLeaveRoomRequest DefaultInstanceForType => null;

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

			internal Builder(CCLeaveRoomRequest cloneFrom)
			{
			}

			private CCLeaveRoomRequest PrepareBuilder()
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

			public override CCLeaveRoomRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLeaveRoomRequest other)
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

		private static readonly CCLeaveRoomRequest defaultInstance;

		private static readonly string[] _cCLeaveRoomRequestFieldNames;

		private static readonly uint[] _cCLeaveRoomRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		private int memoizedSerializedSize;

		public static CCLeaveRoomRequest DefaultInstance => null;

		public override CCLeaveRoomRequest DefaultInstanceForType => null;

		protected override CCLeaveRoomRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLeaveRoomRequest()
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

		public static CCLeaveRoomRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLeaveRoomRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLeaveRoomRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCLeaveRoomRequest prototype)
		{
			return null;
		}

		static CCLeaveRoomRequest()
		{
		}
	}
}
