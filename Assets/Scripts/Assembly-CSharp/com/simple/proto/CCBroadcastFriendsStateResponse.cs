using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBroadcastFriendsStateResponse : GeneratedMessageLite<CCBroadcastFriendsStateResponse, CCBroadcastFriendsStateResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBroadcastFriendsStateResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCBroadcastFriendsStateResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBroadcastFriendsStateResponse MessageBeingBuilt => null;

			public override CCBroadcastFriendsStateResponse DefaultInstanceForType => null;

			public bool HasBroadcastType => false;

			public int BroadcastType
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

			public bool HasMesTitle => false;

			public string MesTitle
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasMesConcent => false;

			public string MesConcent
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

			internal Builder(CCBroadcastFriendsStateResponse cloneFrom)
			{
			}

			private CCBroadcastFriendsStateResponse PrepareBuilder()
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

			public override CCBroadcastFriendsStateResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBroadcastFriendsStateResponse other)
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

			public Builder SetBroadcastType(int value)
			{
				return null;
			}

			public Builder ClearBroadcastType()
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

			public Builder SetMesTitle(string value)
			{
				return null;
			}

			public Builder ClearMesTitle()
			{
				return null;
			}

			public Builder SetMesConcent(string value)
			{
				return null;
			}

			public Builder ClearMesConcent()
			{
				return null;
			}
		}

		private static readonly CCBroadcastFriendsStateResponse defaultInstance;

		private static readonly string[] _cCBroadcastFriendsStateResponseFieldNames;

		private static readonly uint[] _cCBroadcastFriendsStateResponseFieldTags;

		public const int BroadcastTypeFieldNumber = 1;

		private bool hasBroadcastType;

		private int broadcastType_;

		public const int FriendUidFieldNumber = 2;

		private bool hasFriendUid;

		private string friendUid_;

		public const int FriendPlayerStateFieldNumber = 3;

		private bool hasFriendPlayerState;

		private CCPlayerStateData friendPlayerState_;

		public const int MesTitleFieldNumber = 4;

		private bool hasMesTitle;

		private string mesTitle_;

		public const int MesConcentFieldNumber = 5;

		private bool hasMesConcent;

		private string mesConcent_;

		private int memoizedSerializedSize;

		public static CCBroadcastFriendsStateResponse DefaultInstance => null;

		public override CCBroadcastFriendsStateResponse DefaultInstanceForType => null;

		protected override CCBroadcastFriendsStateResponse ThisMessage => null;

		public bool HasBroadcastType => false;

		public int BroadcastType => 0;

		public bool HasFriendUid => false;

		public string FriendUid => null;

		public bool HasFriendPlayerState => false;

		public CCPlayerStateData FriendPlayerState => null;

		public bool HasMesTitle => false;

		public string MesTitle => null;

		public bool HasMesConcent => false;

		public string MesConcent => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBroadcastFriendsStateResponse()
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

		public static CCBroadcastFriendsStateResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBroadcastFriendsStateResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBroadcastFriendsStateResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCBroadcastFriendsStateResponse prototype)
		{
			return null;
		}

		static CCBroadcastFriendsStateResponse()
		{
		}
	}
}
