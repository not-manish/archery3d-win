using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRestoreAccountResponse : GeneratedMessageLite<CCRestoreAccountResponse, CCRestoreAccountResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRestoreAccountResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCRestoreAccountResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRestoreAccountResponse MessageBeingBuilt => null;

			public override CCRestoreAccountResponse DefaultInstanceForType => null;

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

			public bool HasItem => false;

			public CCThirdAccountItem Item
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasUserAccount => false;

			public CCUserAccount UserAccount
			{
				get
				{
					return null;
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

			internal Builder(CCRestoreAccountResponse cloneFrom)
			{
			}

			private CCRestoreAccountResponse PrepareBuilder()
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

			public override CCRestoreAccountResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRestoreAccountResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public Builder SetItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder SetItem(CCThirdAccountItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder ClearItem()
			{
				return null;
			}

			public Builder SetUserAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder SetUserAccount(CCUserAccount.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeUserAccount(CCUserAccount value)
			{
				return null;
			}

			public Builder ClearUserAccount()
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

		private static readonly CCRestoreAccountResponse defaultInstance;

		private static readonly string[] _cCRestoreAccountResponseFieldNames;

		private static readonly uint[] _cCRestoreAccountResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		public const int UserAccountFieldNumber = 3;

		private bool hasUserAccount;

		private CCUserAccount userAccount_;

		public const int PlayerFieldNumber = 4;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int IsDeletingFieldNumber = 5;

		private bool hasIsDeleting;

		private bool isDeleting_;

		public const int DeletingLeftMillsFieldNumber = 6;

		private bool hasDeletingLeftMills;

		private int deletingLeftMills_;

		private int memoizedSerializedSize;

		public static CCRestoreAccountResponse DefaultInstance => null;

		public override CCRestoreAccountResponse DefaultInstanceForType => null;

		protected override CCRestoreAccountResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public bool HasUserAccount => false;

		public CCUserAccount UserAccount => null;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasIsDeleting => false;

		public bool IsDeleting => false;

		public bool HasDeletingLeftMills => false;

		public int DeletingLeftMills => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRestoreAccountResponse()
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

		public static CCRestoreAccountResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRestoreAccountResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRestoreAccountResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCRestoreAccountResponse prototype)
		{
			return null;
		}

		static CCRestoreAccountResponse()
		{
		}
	}
}
