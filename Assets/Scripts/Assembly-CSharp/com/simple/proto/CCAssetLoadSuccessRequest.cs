using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAssetLoadSuccessRequest : GeneratedMessageLite<CCAssetLoadSuccessRequest, CCAssetLoadSuccessRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAssetLoadSuccessRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCAssetLoadSuccessRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAssetLoadSuccessRequest MessageBeingBuilt => null;

			public override CCAssetLoadSuccessRequest DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCAssetLoadSuccessRequest cloneFrom)
			{
			}

			private CCAssetLoadSuccessRequest PrepareBuilder()
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

			public override CCAssetLoadSuccessRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAssetLoadSuccessRequest other)
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
		}

		private static readonly CCAssetLoadSuccessRequest defaultInstance;

		private static readonly string[] _cCAssetLoadSuccessRequestFieldNames;

		private static readonly uint[] _cCAssetLoadSuccessRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int GameTypeFieldNumber = 2;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 3;

		private bool hasLevelId;

		private int levelId_;

		private int memoizedSerializedSize;

		public static CCAssetLoadSuccessRequest DefaultInstance => null;

		public override CCAssetLoadSuccessRequest DefaultInstanceForType => null;

		protected override CCAssetLoadSuccessRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAssetLoadSuccessRequest()
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

		public static CCAssetLoadSuccessRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAssetLoadSuccessRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCAssetLoadSuccessRequest prototype)
		{
			return null;
		}

		static CCAssetLoadSuccessRequest()
		{
		}
	}
}
