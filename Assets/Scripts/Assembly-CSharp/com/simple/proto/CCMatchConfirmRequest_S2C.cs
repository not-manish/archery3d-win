using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCMatchConfirmRequest_S2C : GeneratedMessageLite<CCMatchConfirmRequest_S2C, CCMatchConfirmRequest_S2C.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCMatchConfirmRequest_S2C, Builder>
		{
			private bool resultIsReadOnly;

			private CCMatchConfirmRequest_S2C result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCMatchConfirmRequest_S2C MessageBeingBuilt => null;

			public override CCMatchConfirmRequest_S2C DefaultInstanceForType => null;

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

			public bool HasMatchType => false;

			public int MatchType
			{
				get
				{
					return 0;
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

			internal Builder(CCMatchConfirmRequest_S2C cloneFrom)
			{
			}

			private CCMatchConfirmRequest_S2C PrepareBuilder()
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

			public override CCMatchConfirmRequest_S2C BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCMatchConfirmRequest_S2C other)
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

			public Builder SetMatchType(int value)
			{
				return null;
			}

			public Builder ClearMatchType()
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

		private static readonly CCMatchConfirmRequest_S2C defaultInstance;

		private static readonly string[] _cCMatchConfirmRequestS2CFieldNames;

		private static readonly uint[] _cCMatchConfirmRequestS2CFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int MatchTypeFieldNumber = 2;

		private bool hasMatchType;

		private int matchType_;

		public const int GameTypeFieldNumber = 3;

		private bool hasGameType;

		private int gameType_;

		public const int LevelIdFieldNumber = 4;

		private bool hasLevelId;

		private int levelId_;

		private int memoizedSerializedSize;

		public static CCMatchConfirmRequest_S2C DefaultInstance => null;

		public override CCMatchConfirmRequest_S2C DefaultInstanceForType => null;

		protected override CCMatchConfirmRequest_S2C ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasMatchType => false;

		public int MatchType => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCMatchConfirmRequest_S2C()
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

		public static CCMatchConfirmRequest_S2C ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(Stream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCMatchConfirmRequest_S2C ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCMatchConfirmRequest_S2C MakeReadOnly()
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

		public static Builder CreateBuilder(CCMatchConfirmRequest_S2C prototype)
		{
			return null;
		}

		static CCMatchConfirmRequest_S2C()
		{
		}
	}
}
