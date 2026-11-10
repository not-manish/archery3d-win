using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCFriendItem : GeneratedMessageLite<CCFriendItem, CCFriendItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCFriendItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCFriendItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCFriendItem MessageBeingBuilt => null;

			public override CCFriendItem DefaultInstanceForType => null;

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

			public bool HasFriendPlayerState => false;

			public CCPlayerStateData FriendPlayerState
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasTodayHasSendGifts => false;

			public bool TodayHasSendGifts
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasFriendTrophy => false;

			public int FriendTrophy
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasFriendDbName => false;

			public string FriendDbName
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

			internal Builder(CCFriendItem cloneFrom)
			{
			}

			private CCFriendItem PrepareBuilder()
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

			public override CCFriendItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCFriendItem other)
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

			public Builder SetFriendPlayerState(CCPlayerStateData value)
			{
				return null;
			}

			public Builder SetFriendPlayerState(CCPlayerStateData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeFriendPlayerState(CCPlayerStateData value)
			{
				return null;
			}

			public Builder ClearFriendPlayerState()
			{
				return null;
			}

			public Builder SetTodayHasSendGifts(bool value)
			{
				return null;
			}

			public Builder ClearTodayHasSendGifts()
			{
				return null;
			}

			public Builder SetFriendTrophy(int value)
			{
				return null;
			}

			public Builder ClearFriendTrophy()
			{
				return null;
			}

			public Builder SetFriendDbName(string value)
			{
				return null;
			}

			public Builder ClearFriendDbName()
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

		private static readonly CCFriendItem defaultInstance;

		private static readonly string[] _cCFriendItemFieldNames;

		private static readonly uint[] _cCFriendItemFieldTags;

		public const int FriendUidFieldNumber = 1;

		private bool hasFriendUid;

		private string friendUid_;

		public const int FriendFacebookIdFieldNumber = 2;

		private bool hasFriendFacebookId;

		private string friendFacebookId_;

		public const int FriendPlayerStateFieldNumber = 3;

		private bool hasFriendPlayerState;

		private CCPlayerStateData friendPlayerState_;

		public const int TodayHasSendGiftsFieldNumber = 4;

		private bool hasTodayHasSendGifts;

		private bool todayHasSendGifts_;

		public const int FriendTrophyFieldNumber = 5;

		private bool hasFriendTrophy;

		private int friendTrophy_;

		public const int FriendDbNameFieldNumber = 6;

		private bool hasFriendDbName;

		private string friendDbName_;

		public const int HideFriendPhotoFieldNumber = 7;

		private bool hasHideFriendPhoto;

		private bool hideFriendPhoto_;

		private int memoizedSerializedSize;

		public static CCFriendItem DefaultInstance => null;

		public override CCFriendItem DefaultInstanceForType => null;

		protected override CCFriendItem ThisMessage => null;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public bool HasFriendFacebookId => false;

		public string FriendFacebookId => null;

		public bool HasFriendPlayerState => false;

		public CCPlayerStateData FriendPlayerState => null;

		public bool HasTodayHasSendGifts => false;

		public bool TodayHasSendGifts => false;

		public bool HasFriendTrophy => false;

		public int FriendTrophy => 0;

		public bool HasFriendDbName => false;

		public string FriendDbName => null;

		public bool HasHideFriendPhoto => false;

		public bool HideFriendPhoto => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCFriendItem()
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

		public static CCFriendItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCFriendItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCFriendItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCFriendItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCFriendItem prototype)
		{
			return null;
		}

		static CCFriendItem()
		{
		}
	}
}
