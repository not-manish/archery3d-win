using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRoundDataChangeResponse : GeneratedMessageLite<CCRoundDataChangeResponse, CCRoundDataChangeResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRoundDataChangeResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCRoundDataChangeResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRoundDataChangeResponse MessageBeingBuilt => null;

			public override CCRoundDataChangeResponse DefaultInstanceForType => null;

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

			public bool HasRoundData => false;

			public CCRoundData RoundData
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

			internal Builder(CCRoundDataChangeResponse cloneFrom)
			{
			}

			private CCRoundDataChangeResponse PrepareBuilder()
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

			public override CCRoundDataChangeResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRoundDataChangeResponse other)
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

			public Builder SetRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder SetRoundData(CCRoundData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder ClearRoundData()
			{
				return null;
			}
		}

		private static readonly CCRoundDataChangeResponse defaultInstance;

		private static readonly string[] _cCRoundDataChangeResponseFieldNames;

		private static readonly uint[] _cCRoundDataChangeResponseFieldTags;

		public const int GameTypeFieldNumber = 1;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 2;

		private bool hasPvpType;

		private int pvpType_;

		public const int LevelIdFieldNumber = 3;

		private bool hasLevelId;

		private int levelId_;

		public const int RoundDataFieldNumber = 4;

		private bool hasRoundData;

		private CCRoundData roundData_;

		private int memoizedSerializedSize;

		public static CCRoundDataChangeResponse DefaultInstance => null;

		public override CCRoundDataChangeResponse DefaultInstanceForType => null;

		protected override CCRoundDataChangeResponse ThisMessage => null;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRoundDataChangeResponse()
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

		public static CCRoundDataChangeResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRoundDataChangeResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRoundDataChangeResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCRoundDataChangeResponse prototype)
		{
			return null;
		}

		static CCRoundDataChangeResponse()
		{
		}
	}
}
