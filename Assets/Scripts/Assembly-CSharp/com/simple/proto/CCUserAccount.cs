using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCUserAccount : GeneratedMessageLite<CCUserAccount, CCUserAccount.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCUserAccount, Builder>
		{
			private bool resultIsReadOnly;

			private CCUserAccount result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCUserAccount MessageBeingBuilt => null;

			public override CCUserAccount DefaultInstanceForType => null;

			public bool HasId => false;

			public string Id
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSocialFacebookId => false;

			public string SocialFacebookId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSocialGoogleId => false;

			public string SocialGoogleId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasMailAddr => false;

			public string MailAddr
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasPhoneNo => false;

			public string PhoneNo
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasThirdToken => false;

			public string ThirdToken
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasTokenValidEt => false;

			public long TokenValidEt
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasIsDeleting => false;

			public bool IsDeleting
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasDeletingLeftMills => false;

			public int DeletingLeftMills
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

			internal Builder(CCUserAccount cloneFrom)
			{
			}

			private CCUserAccount PrepareBuilder()
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

			public override CCUserAccount BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCUserAccount other)
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

			public Builder SetId(string value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}

			public Builder SetSocialFacebookId(string value)
			{
				return null;
			}

			public Builder ClearSocialFacebookId()
			{
				return null;
			}

			public Builder SetSocialGoogleId(string value)
			{
				return null;
			}

			public Builder ClearSocialGoogleId()
			{
				return null;
			}

			public Builder SetMailAddr(string value)
			{
				return null;
			}

			public Builder ClearMailAddr()
			{
				return null;
			}

			public Builder SetPhoneNo(string value)
			{
				return null;
			}

			public Builder ClearPhoneNo()
			{
				return null;
			}

			public Builder SetThirdToken(string value)
			{
				return null;
			}

			public Builder ClearThirdToken()
			{
				return null;
			}

			public Builder SetTokenValidEt(long value)
			{
				return null;
			}

			public Builder ClearTokenValidEt()
			{
				return null;
			}

			public Builder SetIsDeleting(bool value)
			{
				return null;
			}

			public Builder ClearIsDeleting()
			{
				return null;
			}

			public Builder SetDeletingLeftMills(int value)
			{
				return null;
			}

			public Builder ClearDeletingLeftMills()
			{
				return null;
			}
		}

		private static readonly CCUserAccount defaultInstance;

		private static readonly string[] _cCUserAccountFieldNames;

		private static readonly uint[] _cCUserAccountFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		public const int SocialFacebookIdFieldNumber = 2;

		private bool hasSocialFacebookId;

		private string socialFacebookId_;

		public const int SocialGoogleIdFieldNumber = 3;

		private bool hasSocialGoogleId;

		private string socialGoogleId_;

		public const int MailAddrFieldNumber = 4;

		private bool hasMailAddr;

		private string mailAddr_;

		public const int PhoneNoFieldNumber = 5;

		private bool hasPhoneNo;

		private string phoneNo_;

		public const int ThirdTokenFieldNumber = 6;

		private bool hasThirdToken;

		private string thirdToken_;

		public const int TokenValidEtFieldNumber = 7;

		private bool hasTokenValidEt;

		private long tokenValidEt_;

		public const int IsDeletingFieldNumber = 8;

		private bool hasIsDeleting;

		private bool isDeleting_;

		public const int DeletingLeftMillsFieldNumber = 9;

		private bool hasDeletingLeftMills;

		private int deletingLeftMills_;

		private int memoizedSerializedSize;

		public static CCUserAccount DefaultInstance => null;

		public override CCUserAccount DefaultInstanceForType => null;

		protected override CCUserAccount ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public bool HasSocialFacebookId => false;

		public string SocialFacebookId => null;

		public bool HasSocialGoogleId => false;

		public string SocialGoogleId => null;

		public bool HasMailAddr => false;

		public string MailAddr => null;

		public bool HasPhoneNo => false;

		public string PhoneNo => null;

		public bool HasThirdToken => false;

		public string ThirdToken => null;

		public bool HasTokenValidEt => false;

		public long TokenValidEt => 0L;

		public bool HasIsDeleting => false;

		public bool IsDeleting => false;

		public bool HasDeletingLeftMills => false;

		public int DeletingLeftMills => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCUserAccount()
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

		public static CCUserAccount ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(Stream input)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUserAccount ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCUserAccount ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCUserAccount ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCUserAccount MakeReadOnly()
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

		public static Builder CreateBuilder(CCUserAccount prototype)
		{
			return null;
		}

		static CCUserAccount()
		{
		}
	}
}
