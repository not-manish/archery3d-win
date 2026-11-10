using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRankItem : GeneratedMessageLite<CCRankItem, CCRankItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRankItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCRankItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRankItem MessageBeingBuilt => null;

			public override CCRankItem DefaultInstanceForType => null;

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

			public bool HasName => false;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasGold => false;

			public long Gold
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasFacebookId => false;

			public string FacebookId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasHideFacebookPhoto => false;

			public bool HideFacebookPhoto
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

			internal Builder(CCRankItem cloneFrom)
			{
			}

			private CCRankItem PrepareBuilder()
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

			public override CCRankItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRankItem other)
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

			public Builder SetName(string value)
			{
				return null;
			}

			public Builder ClearName()
			{
				return null;
			}

			public Builder SetGold(long value)
			{
				return null;
			}

			public Builder ClearGold()
			{
				return null;
			}

			public Builder SetFacebookId(string value)
			{
				return null;
			}

			public Builder ClearFacebookId()
			{
				return null;
			}

			public Builder SetHideFacebookPhoto(bool value)
			{
				return null;
			}

			public Builder ClearHideFacebookPhoto()
			{
				return null;
			}
		}

		private static readonly CCRankItem defaultInstance;

		private static readonly string[] _cCRankItemFieldNames;

		private static readonly uint[] _cCRankItemFieldTags;

		public const int UidFieldNumber = 3;

		private bool hasUid;

		private string uid_;

		public const int NameFieldNumber = 1;

		private bool hasName;

		private string name_;

		public const int GoldFieldNumber = 2;

		private bool hasGold;

		private long gold_;

		public const int FacebookIdFieldNumber = 4;

		private bool hasFacebookId;

		private string facebookId_;

		public const int HideFacebookPhotoFieldNumber = 5;

		private bool hasHideFacebookPhoto;

		private bool hideFacebookPhoto_;

		private int memoizedSerializedSize;

		public static CCRankItem DefaultInstance => null;

		public override CCRankItem DefaultInstanceForType => null;

		protected override CCRankItem ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasName => false;

		public string Name => null;

		public bool HasGold => false;

		public long Gold => 0L;

		public bool HasFacebookId => false;

		public string FacebookId => null;

		public bool HasHideFacebookPhoto => false;

		public bool HideFacebookPhoto => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRankItem()
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

		public static CCRankItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRankItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRankItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRankItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRankItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRankItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRankItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRankItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRankItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRankItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRankItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCRankItem prototype)
		{
			return null;
		}

		static CCRankItem()
		{
		}
	}
}
