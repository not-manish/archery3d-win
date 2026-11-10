using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCMailItem : GeneratedMessageLite<CCMailItem, CCMailItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCMailItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCMailItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCMailItem MessageBeingBuilt => null;

			public override CCMailItem DefaultInstanceForType => null;

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

			public bool HasMailType => false;

			public int MailType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasMailId => false;

			public long MailId
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasSubject => false;

			public string Subject
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasContent => false;

			public string Content
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSenderId => false;

			public string SenderId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSenderFacebookId => false;

			public string SenderFacebookId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSenderName => false;

			public string SenderName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasValidEt => false;

			public long ValidEt
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasState => false;

			public int State
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardType => false;

			public int RewardType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardId => false;

			public int RewardId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardCount => false;

			public int RewardCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHideSenderPhoto => false;

			public bool HideSenderPhoto
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

			internal Builder(CCMailItem cloneFrom)
			{
			}

			private CCMailItem PrepareBuilder()
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

			public override CCMailItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCMailItem other)
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

			public Builder SetMailType(int value)
			{
				return null;
			}

			public Builder ClearMailType()
			{
				return null;
			}

			public Builder SetMailId(long value)
			{
				return null;
			}

			public Builder ClearMailId()
			{
				return null;
			}

			public Builder SetSubject(string value)
			{
				return null;
			}

			public Builder ClearSubject()
			{
				return null;
			}

			public Builder SetContent(string value)
			{
				return null;
			}

			public Builder ClearContent()
			{
				return null;
			}

			public Builder SetSenderId(string value)
			{
				return null;
			}

			public Builder ClearSenderId()
			{
				return null;
			}

			public Builder SetSenderFacebookId(string value)
			{
				return null;
			}

			public Builder ClearSenderFacebookId()
			{
				return null;
			}

			public Builder SetSenderName(string value)
			{
				return null;
			}

			public Builder ClearSenderName()
			{
				return null;
			}

			public Builder SetValidEt(long value)
			{
				return null;
			}

			public Builder ClearValidEt()
			{
				return null;
			}

			public Builder SetState(int value)
			{
				return null;
			}

			public Builder ClearState()
			{
				return null;
			}

			public Builder SetRewardType(int value)
			{
				return null;
			}

			public Builder ClearRewardType()
			{
				return null;
			}

			public Builder SetRewardId(int value)
			{
				return null;
			}

			public Builder ClearRewardId()
			{
				return null;
			}

			public Builder SetRewardCount(int value)
			{
				return null;
			}

			public Builder ClearRewardCount()
			{
				return null;
			}

			public Builder SetHideSenderPhoto(bool value)
			{
				return null;
			}

			public Builder ClearHideSenderPhoto()
			{
				return null;
			}
		}

		private static readonly CCMailItem defaultInstance;

		private static readonly string[] _cCMailItemFieldNames;

		private static readonly uint[] _cCMailItemFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int MailTypeFieldNumber = 2;

		private bool hasMailType;

		private int mailType_;

		public const int MailIdFieldNumber = 3;

		private bool hasMailId;

		private long mailId_;

		public const int SubjectFieldNumber = 4;

		private bool hasSubject;

		private string subject_;

		public const int ContentFieldNumber = 5;

		private bool hasContent;

		private string content_;

		public const int SenderIdFieldNumber = 6;

		private bool hasSenderId;

		private string senderId_;

		public const int SenderFacebookIdFieldNumber = 13;

		private bool hasSenderFacebookId;

		private string senderFacebookId_;

		public const int SenderNameFieldNumber = 7;

		private bool hasSenderName;

		private string senderName_;

		public const int ValidEtFieldNumber = 8;

		private bool hasValidEt;

		private long validEt_;

		public const int StateFieldNumber = 9;

		private bool hasState;

		private int state_;

		public const int RewardTypeFieldNumber = 10;

		private bool hasRewardType;

		private int rewardType_;

		public const int RewardIdFieldNumber = 11;

		private bool hasRewardId;

		private int rewardId_;

		public const int RewardCountFieldNumber = 12;

		private bool hasRewardCount;

		private int rewardCount_;

		public const int HideSenderPhotoFieldNumber = 14;

		private bool hasHideSenderPhoto;

		private bool hideSenderPhoto_;

		private int memoizedSerializedSize;

		public static CCMailItem DefaultInstance => null;

		public override CCMailItem DefaultInstanceForType => null;

		protected override CCMailItem ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasMailType => false;

		public int MailType => 0;

		public bool HasMailId => false;

		public long MailId => 0L;

		public bool HasSubject => false;

		public string Subject => null;

		public bool HasContent => false;

		public string Content => null;

		public bool HasSenderId => false;

		public string SenderId => null;

		public bool HasSenderFacebookId => false;

		public string SenderFacebookId => null;

		public bool HasSenderName => false;

		public string SenderName => null;

		public bool HasValidEt => false;

		public long ValidEt => 0L;

		public bool HasState => false;

		public int State => 0;

		public bool HasRewardType => false;

		public int RewardType => 0;

		public bool HasRewardId => false;

		public int RewardId => 0;

		public bool HasRewardCount => false;

		public int RewardCount => 0;

		public bool HasHideSenderPhoto => false;

		public bool HideSenderPhoto => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCMailItem()
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

		public static CCMailItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCMailItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMailItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCMailItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMailItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCMailItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMailItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCMailItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMailItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCMailItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCMailItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCMailItem prototype)
		{
			return null;
		}

		static CCMailItem()
		{
		}
	}
}
