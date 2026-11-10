using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBingoData : GeneratedMessageLite<CCBingoData, CCBingoData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBingoData, Builder>
		{
			private bool resultIsReadOnly;

			private CCBingoData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBingoData MessageBeingBuilt => null;

			public override CCBingoData DefaultInstanceForType => null;

			public bool HasSumGames => false;

			public int SumGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasWinGames => false;

			public int WinGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLoseGames => false;

			public int LoseGames
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCBingoLevel> LevelInfosList => null;

			public int LevelInfosCount => 0;

			public Builder()
			{
			}

			internal Builder(CCBingoData cloneFrom)
			{
			}

			private CCBingoData PrepareBuilder()
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

			public override CCBingoData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBingoData other)
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

			public Builder SetSumGames(int value)
			{
				return null;
			}

			public Builder ClearSumGames()
			{
				return null;
			}

			public Builder SetWinGames(int value)
			{
				return null;
			}

			public Builder ClearWinGames()
			{
				return null;
			}

			public Builder SetLoseGames(int value)
			{
				return null;
			}

			public Builder ClearLoseGames()
			{
				return null;
			}

			public CCBingoLevel GetLevelInfos(int index)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCBingoLevel value)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCBingoLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddLevelInfos(CCBingoLevel value)
			{
				return null;
			}

			public Builder AddLevelInfos(CCBingoLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeLevelInfos(IEnumerable<CCBingoLevel> values)
			{
				return null;
			}

			public Builder ClearLevelInfos()
			{
				return null;
			}
		}

		private static readonly CCBingoData defaultInstance;

		private static readonly string[] _cCBingoDataFieldNames;

		private static readonly uint[] _cCBingoDataFieldTags;

		public const int SumGamesFieldNumber = 1;

		private bool hasSumGames;

		private int sumGames_;

		public const int WinGamesFieldNumber = 2;

		private bool hasWinGames;

		private int winGames_;

		public const int LoseGamesFieldNumber = 3;

		private bool hasLoseGames;

		private int loseGames_;

		public const int LevelInfosFieldNumber = 4;

		private PopsicleList<CCBingoLevel> levelInfos_;

		private int memoizedSerializedSize;

		public static CCBingoData DefaultInstance => null;

		public override CCBingoData DefaultInstanceForType => null;

		protected override CCBingoData ThisMessage => null;

		public bool HasSumGames => false;

		public int SumGames => 0;

		public bool HasWinGames => false;

		public int WinGames => 0;

		public bool HasLoseGames => false;

		public int LoseGames => 0;

		public IList<CCBingoLevel> LevelInfosList => null;

		public int LevelInfosCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBingoData()
		{
		}

		public CCBingoLevel GetLevelInfos(int index)
		{
			return null;
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

		public static CCBingoData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBingoData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBingoData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBingoData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBingoData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBingoData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBingoData MakeReadOnly()
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

		public static Builder CreateBuilder(CCBingoData prototype)
		{
			return null;
		}

		static CCBingoData()
		{
		}
	}
}
