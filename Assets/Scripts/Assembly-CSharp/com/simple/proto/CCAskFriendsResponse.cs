using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAskFriendsResponse : GeneratedMessageLite<CCAskFriendsResponse, CCAskFriendsResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAskFriendsResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCAskFriendsResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAskFriendsResponse MessageBeingBuilt => null;

			public override CCAskFriendsResponse DefaultInstanceForType => null;

			public bool HasType => false;

			public int Type
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasResult => false;

			public int Result
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPlayer => false;

			public CCPlayer Player
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<CCFriendItem> FriendsItemList => null;

			public int FriendsItemCount => 0;

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

			public bool HasFriendFbId => false;

			public string FriendFbId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasHideFriendPhoto => false;

			public bool HideFriendPhoto
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCAskFriendsResponse cloneFrom)
			{
			}

			private CCAskFriendsResponse PrepareBuilder()
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

			public override CCAskFriendsResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAskFriendsResponse other)
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

			public Builder SetType(int value)
			{
				return null;
			}

			public Builder ClearType()
			{
				return null;
			}

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearPlayer()
			{
				return null;
			}

			public CCFriendItem GetFriendsItem(int index)
			{
				return null;
			}

			public Builder SetFriendsItem(int index, CCFriendItem value)
			{
				return null;
			}

			public Builder SetFriendsItem(int index, CCFriendItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFriendsItem(CCFriendItem value)
			{
				return null;
			}

			public Builder AddFriendsItem(CCFriendItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFriendsItem(IEnumerable<CCFriendItem> values)
			{
				return null;
			}

			public Builder ClearFriendsItem()
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

			public Builder SetFriendName(string value)
			{
				return null;
			}

			public Builder ClearFriendName()
			{
				return null;
			}

			public Builder SetFriendFbId(string value)
			{
				return null;
			}

			public Builder ClearFriendFbId()
			{
				return null;
			}

			public Builder SetHideFriendPhoto(bool value)
			{
				return null;
			}

			public Builder ClearHideFriendPhoto()
			{
				return null;
			}
		}

		private static readonly CCAskFriendsResponse defaultInstance;

		private static readonly string[] _cCAskFriendsResponseFieldNames;

		private static readonly uint[] _cCAskFriendsResponseFieldTags;

		public const int TypeFieldNumber = 1;

		private bool hasType;

		private int type_;

		public const int ResultFieldNumber = 2;

		private bool hasResult;

		private int result_;

		public const int PlayerFieldNumber = 3;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int FriendsItemFieldNumber = 4;

		private PopsicleList<CCFriendItem> friendsItem_;

		public const int GameTypeFieldNumber = 5;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 6;

		private bool hasLevelId;

		private int levelId_;

		public const int FriendUidFieldNumber = 7;

		private bool hasFriendUid;

		private string friendUid_;

		public const int FriendNameFieldNumber = 8;

		private bool hasFriendName;

		private string friendName_;

		public const int FriendFbIdFieldNumber = 9;

		private bool hasFriendFbId;

		private string friendFbId_;

		public const int HideFriendPhotoFieldNumber = 10;

		private bool hasHideFriendPhoto;

		private bool hideFriendPhoto_;

		private int memoizedSerializedSize;

		public static CCAskFriendsResponse DefaultInstance => null;

		public override CCAskFriendsResponse DefaultInstanceForType => null;

		protected override CCAskFriendsResponse ThisMessage => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public IList<CCFriendItem> FriendsItemList => null;

		public int FriendsItemCount => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public bool HasFriendName => false;

		public string FriendName => null;

		public bool HasFriendFbId => false;

		public string FriendFbId => null;

		public bool HasHideFriendPhoto => false;

		public bool HideFriendPhoto => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAskFriendsResponse()
		{
		}

		public CCFriendItem GetFriendsItem(int index)
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

		public static CCAskFriendsResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAskFriendsResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAskFriendsResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCAskFriendsResponse prototype)
		{
			return null;
		}

		static CCAskFriendsResponse()
		{
		}
	}
}
