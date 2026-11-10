using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCIsInMatchingRequest : GeneratedMessageLite<CCIsInMatchingRequest, CCIsInMatchingRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCIsInMatchingRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCIsInMatchingRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCIsInMatchingRequest MessageBeingBuilt => null;

			public override CCIsInMatchingRequest DefaultInstanceForType => null;

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

			internal Builder(CCIsInMatchingRequest cloneFrom)
			{
			}

			private CCIsInMatchingRequest PrepareBuilder()
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

			public override CCIsInMatchingRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCIsInMatchingRequest other)
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

		private static readonly CCIsInMatchingRequest defaultInstance;

		private static readonly string[] _cCIsInMatchingRequestFieldNames;

		private static readonly uint[] _cCIsInMatchingRequestFieldTags;

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

		public static CCIsInMatchingRequest DefaultInstance => null;

		public override CCIsInMatchingRequest DefaultInstanceForType => null;

		protected override CCIsInMatchingRequest ThisMessage => null;

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

		private CCIsInMatchingRequest()
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

		public static CCIsInMatchingRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCIsInMatchingRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCIsInMatchingRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCIsInMatchingRequest prototype)
		{
			return null;
		}

		static CCIsInMatchingRequest()
		{
		}
	}
}
