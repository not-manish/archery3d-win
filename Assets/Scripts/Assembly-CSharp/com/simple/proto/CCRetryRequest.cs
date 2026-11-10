using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRetryRequest : GeneratedMessageLite<CCRetryRequest, CCRetryRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRetryRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCRetryRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRetryRequest MessageBeingBuilt => null;

			public override CCRetryRequest DefaultInstanceForType => null;

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

			public bool HasPvpType => false;

			public int PvpType
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

			internal Builder(CCRetryRequest cloneFrom)
			{
			}

			private CCRetryRequest PrepareBuilder()
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

			public override CCRetryRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRetryRequest other)
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

			public Builder SetPvpType(int value)
			{
				return null;
			}

			public Builder ClearPvpType()
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

		private static readonly CCRetryRequest defaultInstance;

		private static readonly string[] _cCRetryRequestFieldNames;

		private static readonly uint[] _cCRetryRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int GameTypeFieldNumber = 2;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 3;

		private bool hasPvpType;

		private int pvpType_;

		public const int LevelIdFieldNumber = 4;

		private bool hasLevelId;

		private int levelId_;

		private int memoizedSerializedSize;

		public static CCRetryRequest DefaultInstance => null;

		public override CCRetryRequest DefaultInstanceForType => null;

		protected override CCRetryRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRetryRequest()
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

		public static CCRetryRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRetryRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRetryRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRetryRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCRetryRequest prototype)
		{
			return null;
		}

		static CCRetryRequest()
		{
		}
	}
}
