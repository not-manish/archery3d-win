using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCFriendAskInfo : GeneratedMessageLite<CCFriendAskInfo, CCFriendAskInfo.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCFriendAskInfo, Builder>
		{
			private bool resultIsReadOnly;

			private CCFriendAskInfo result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCFriendAskInfo MessageBeingBuilt => null;

			public override CCFriendAskInfo DefaultInstanceForType => null;

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

			public bool HasFriendName => false;

			public string FriendName
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

			internal Builder(CCFriendAskInfo cloneFrom)
			{
			}

			private CCFriendAskInfo PrepareBuilder()
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

			public override CCFriendAskInfo BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCFriendAskInfo other)
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

			public Builder SetFriendUid(string value)
			{
				return null;
			}

			public Builder ClearFriendUid()
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

			public Builder SetFriendName(string value)
			{
				return null;
			}

			public Builder ClearFriendName()
			{
				return null;
			}
		}

		private static readonly CCFriendAskInfo defaultInstance;

		private static readonly string[] _cCFriendAskInfoFieldNames;

		private static readonly uint[] _cCFriendAskInfoFieldTags;

		public const int FriendUidFieldNumber = 1;

		private bool hasFriendUid;

		private string friendUid_;

		public const int FriendFacebookIdFieldNumber = 2;

		private bool hasFriendFacebookId;

		private string friendFacebookId_;

		public const int FriendNameFieldNumber = 3;

		private bool hasFriendName;

		private string friendName_;

		private int memoizedSerializedSize;

		public static CCFriendAskInfo DefaultInstance => null;

		public override CCFriendAskInfo DefaultInstanceForType => null;

		protected override CCFriendAskInfo ThisMessage => null;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public bool HasFriendFacebookId => false;

		public string FriendFacebookId => null;

		public bool HasFriendName => false;

		public string FriendName => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCFriendAskInfo()
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

		public static CCFriendAskInfo ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(Stream input)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendAskInfo ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCFriendAskInfo ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCFriendAskInfo ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCFriendAskInfo MakeReadOnly()
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

		public static Builder CreateBuilder(CCFriendAskInfo prototype)
		{
			return null;
		}

		static CCFriendAskInfo()
		{
		}
	}
}
