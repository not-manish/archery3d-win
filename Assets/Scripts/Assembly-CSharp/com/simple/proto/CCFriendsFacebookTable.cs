using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCFriendsFacebookTable : GeneratedMessageLite<CCFriendsFacebookTable, CCFriendsFacebookTable.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCFriendsFacebookTable, Builder>
		{
			private bool resultIsReadOnly;

			private CCFriendsFacebookTable result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCFriendsFacebookTable MessageBeingBuilt => null;

			public override CCFriendsFacebookTable DefaultInstanceForType => null;

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

			public bool HasFriendFacebookId => false;

			public string FriendFacebookId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasFriendUid => false;

			public string FriendUid
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLastSendGiftsDayStartTimeMil => false;

			public long LastSendGiftsDayStartTimeMil
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

			internal Builder(CCFriendsFacebookTable cloneFrom)
			{
			}

			private CCFriendsFacebookTable PrepareBuilder()
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

			public override CCFriendsFacebookTable BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCFriendsFacebookTable other)
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

			public Builder SetFriendFacebookId(string value)
			{
				return null;
			}

			public Builder ClearFriendFacebookId()
			{
				return null;
			}

			public Builder SetFriendUid(string value)
			{
				return null;
			}

			public Builder ClearFriendUid()
			{
				return null;
			}

			public Builder SetLastSendGiftsDayStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearLastSendGiftsDayStartTimeMil()
			{
				return null;
			}
		}

		private static readonly CCFriendsFacebookTable defaultInstance;

		private static readonly string[] _cCFriendsFacebookTableFieldNames;

		private static readonly uint[] _cCFriendsFacebookTableFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int FriendFacebookIdFieldNumber = 2;

		private bool hasFriendFacebookId;

		private string friendFacebookId_;

		public const int FriendUidFieldNumber = 3;

		private bool hasFriendUid;

		private string friendUid_;

		public const int LastSendGiftsDayStartTimeMilFieldNumber = 4;

		private bool hasLastSendGiftsDayStartTimeMil;

		private long lastSendGiftsDayStartTimeMil_;

		private int memoizedSerializedSize;

		public static CCFriendsFacebookTable DefaultInstance => null;

		public override CCFriendsFacebookTable DefaultInstanceForType => null;

		protected override CCFriendsFacebookTable ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasFriendFacebookId => false;

		public string FriendFacebookId => null;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public bool HasLastSendGiftsDayStartTimeMil => false;

		public long LastSendGiftsDayStartTimeMil => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCFriendsFacebookTable()
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

		public static CCFriendsFacebookTable ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(Stream input)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCFriendsFacebookTable ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCFriendsFacebookTable MakeReadOnly()
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

		public static Builder CreateBuilder(CCFriendsFacebookTable prototype)
		{
			return null;
		}

		static CCFriendsFacebookTable()
		{
		}
	}
}
