using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCMatchRequest : GeneratedMessageLite<CCMatchRequest, CCMatchRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCMatchRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCMatchRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCMatchRequest MessageBeingBuilt => null;

			public override CCMatchRequest DefaultInstanceForType => null;

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

			public bool HasMatchType => false;

			public int MatchType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGameType => false;

			public int GameType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevelId => false;

			public int LevelId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevelIndex => false;

			public int LevelIndex
			{
				get
				{
					return 0;
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

			public Builder()
			{
			}

			internal Builder(CCMatchRequest cloneFrom)
			{
			}

			private CCMatchRequest PrepareBuilder()
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

			public override CCMatchRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCMatchRequest other)
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

			public Builder SetMatchType(int value)
			{
				return null;
			}

			public Builder ClearMatchType()
			{
				return null;
			}

			public Builder SetGameType(int value)
			{
				return null;
			}

			public Builder ClearGameType()
			{
				return null;
			}

			public Builder SetLevelId(int value)
			{
				return null;
			}

			public Builder ClearLevelId()
			{
				return null;
			}

			public Builder SetLevelIndex(int value)
			{
				return null;
			}

			public Builder ClearLevelIndex()
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
		}

		private static readonly CCMatchRequest defaultInstance;

		private static readonly string[] _cCMatchRequestFieldNames;

		private static readonly uint[] _cCMatchRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int MatchTypeFieldNumber = 2;

		private bool hasMatchType;

		private int matchType_;

		public const int GameTypeFieldNumber = 3;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 4;

		private bool hasLevelId;

		private int levelId_;

		public const int LevelIndexFieldNumber = 5;

		private bool hasLevelIndex;

		private int levelIndex_;

		public const int FriendUidFieldNumber = 6;

		private bool hasFriendUid;

		private string friendUid_;

		private int memoizedSerializedSize;

		public static CCMatchRequest DefaultInstance => null;

		public override CCMatchRequest DefaultInstanceForType => null;

		protected override CCMatchRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasMatchType => false;

		public int MatchType => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasLevelIndex => false;

		public int LevelIndex => 0;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCMatchRequest()
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

		public static CCMatchRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCMatchRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCMatchRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCMatchRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCMatchRequest prototype)
		{
			return null;
		}

		static CCMatchRequest()
		{
		}
	}
}
