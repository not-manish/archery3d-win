using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAskFriendsRequest : GeneratedMessageLite<CCAskFriendsRequest, CCAskFriendsRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAskFriendsRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCAskFriendsRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAskFriendsRequest MessageBeingBuilt => null;

			public override CCAskFriendsRequest DefaultInstanceForType => null;

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

			public bool HasAskType => false;

			public int AskType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCFriendAskInfo> FriendInfosList => null;

			public int FriendInfosCount => 0;

			public bool HasAcceptInviting => false;

			public bool AcceptInviting
			{
				get
				{
					return false;
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

			internal Builder(CCAskFriendsRequest cloneFrom)
			{
			}

			private CCAskFriendsRequest PrepareBuilder()
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

			public override CCAskFriendsRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAskFriendsRequest other)
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

			public Builder SetAskType(int value)
			{
				return null;
			}

			public Builder ClearAskType()
			{
				return null;
			}

			public CCFriendAskInfo GetFriendInfos(int index)
			{
				return null;
			}

			public Builder SetFriendInfos(int index, CCFriendAskInfo value)
			{
				return null;
			}

			public Builder SetFriendInfos(int index, CCFriendAskInfo.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFriendInfos(CCFriendAskInfo value)
			{
				return null;
			}

			public Builder AddFriendInfos(CCFriendAskInfo.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFriendInfos(IEnumerable<CCFriendAskInfo> values)
			{
				return null;
			}

			public Builder ClearFriendInfos()
			{
				return null;
			}

			public Builder SetAcceptInviting(bool value)
			{
				return null;
			}

			public Builder ClearAcceptInviting()
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

			public Builder SetFriendUid(string value)
			{
				return null;
			}

			public Builder ClearFriendUid()
			{
				return null;
			}
		}

		private static readonly CCAskFriendsRequest defaultInstance;

		private static readonly string[] _cCAskFriendsRequestFieldNames;

		private static readonly uint[] _cCAskFriendsRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int AskTypeFieldNumber = 2;

		private bool hasAskType;

		private int askType_;

		public const int FriendInfosFieldNumber = 3;

		private PopsicleList<CCFriendAskInfo> friendInfos_;

		public const int AcceptInvitingFieldNumber = 4;

		private bool hasAcceptInviting;

		private bool acceptInviting_;

		public const int GameTypeFieldNumber = 5;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 6;

		private bool hasLevelId;

		private int levelId_;

		public const int FriendUidFieldNumber = 7;

		private bool hasFriendUid;

		private string friendUid_;

		private int memoizedSerializedSize;

		public static CCAskFriendsRequest DefaultInstance => null;

		public override CCAskFriendsRequest DefaultInstanceForType => null;

		protected override CCAskFriendsRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasAskType => false;

		public int AskType => 0;

		public IList<CCFriendAskInfo> FriendInfosList => null;

		public int FriendInfosCount => 0;

		public bool HasAcceptInviting => false;

		public bool AcceptInviting => false;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAskFriendsRequest()
		{
		}

		public CCFriendAskInfo GetFriendInfos(int index)
		{
			return null;
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

		public static CCAskFriendsRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAskFriendsRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAskFriendsRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCAskFriendsRequest prototype)
		{
			return null;
		}

		static CCAskFriendsRequest()
		{
		}
	}
}
