using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAssetLoadSuccessResponse : GeneratedMessageLite<CCAssetLoadSuccessResponse, CCAssetLoadSuccessResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAssetLoadSuccessResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCAssetLoadSuccessResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAssetLoadSuccessResponse MessageBeingBuilt => null;

			public override CCAssetLoadSuccessResponse DefaultInstanceForType => null;

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

			internal Builder(CCAssetLoadSuccessResponse cloneFrom)
			{
			}

			private CCAssetLoadSuccessResponse PrepareBuilder()
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

			public override CCAssetLoadSuccessResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAssetLoadSuccessResponse other)
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

		private static readonly CCAssetLoadSuccessResponse defaultInstance;

		private static readonly string[] _cCAssetLoadSuccessResponseFieldNames;

		private static readonly uint[] _cCAssetLoadSuccessResponseFieldTags;

		public const int GameTypeFieldNumber = 1;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 2;

		private bool hasLevelId;

		private int levelId_;

		private int memoizedSerializedSize;

		public static CCAssetLoadSuccessResponse DefaultInstance => null;

		public override CCAssetLoadSuccessResponse DefaultInstanceForType => null;

		protected override CCAssetLoadSuccessResponse ThisMessage => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAssetLoadSuccessResponse()
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

		public static CCAssetLoadSuccessResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAssetLoadSuccessResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAssetLoadSuccessResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCAssetLoadSuccessResponse prototype)
		{
			return null;
		}

		static CCAssetLoadSuccessResponse()
		{
		}
	}
}
