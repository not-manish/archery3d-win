using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCArenaJoinRequest : GeneratedMessageLite<CCArenaJoinRequest, CCArenaJoinRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCArenaJoinRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCArenaJoinRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCArenaJoinRequest MessageBeingBuilt => null;

			public override CCArenaJoinRequest DefaultInstanceForType => null;

			public bool HasUid => false;

			public string Uid
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasArenaType => false;

			public int ArenaType
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

			internal Builder(CCArenaJoinRequest cloneFrom)
			{
			}

			private CCArenaJoinRequest PrepareBuilder()
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

			public override CCArenaJoinRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCArenaJoinRequest other)
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

			public Builder SetUid(string value)
			{
				return null;
			}

			public Builder ClearUid()
			{
				return null;
			}

			public Builder SetArenaType(int value)
			{
				return null;
			}

			public Builder ClearArenaType()
			{
				return null;
			}
		}

		private static readonly CCArenaJoinRequest defaultInstance;

		private static readonly string[] _cCArenaJoinRequestFieldNames;

		private static readonly uint[] _cCArenaJoinRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int ArenaTypeFieldNumber = 2;

		private bool hasArenaType;

		private int arenaType_;

		private int memoizedSerializedSize;

		public static CCArenaJoinRequest DefaultInstance => null;

		public override CCArenaJoinRequest DefaultInstanceForType => null;

		protected override CCArenaJoinRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasArenaType => false;

		public int ArenaType => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCArenaJoinRequest()
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

		public static CCArenaJoinRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCArenaJoinRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCArenaJoinRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCArenaJoinRequest prototype)
		{
			return null;
		}

		static CCArenaJoinRequest()
		{
		}
	}
}
