using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRushData : GeneratedMessageLite<CCRushData, CCRushData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRushData, Builder>
		{
			private bool resultIsReadOnly;

			private CCRushData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRushData MessageBeingBuilt => null;

			public override CCRushData DefaultInstanceForType => null;

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

			public IPopsicleList<CCRushLevel> LevelInfosList => null;

			public int LevelInfosCount => 0;

			public Builder()
			{
			}

			internal Builder(CCRushData cloneFrom)
			{
			}

			private CCRushData PrepareBuilder()
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

			public override CCRushData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRushData other)
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

			public CCRushLevel GetLevelInfos(int index)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCRushLevel value)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCRushLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddLevelInfos(CCRushLevel value)
			{
				return null;
			}

			public Builder AddLevelInfos(CCRushLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeLevelInfos(IEnumerable<CCRushLevel> values)
			{
				return null;
			}

			public Builder ClearLevelInfos()
			{
				return null;
			}
		}

		private static readonly CCRushData defaultInstance;

		private static readonly string[] _cCRushDataFieldNames;

		private static readonly uint[] _cCRushDataFieldTags;

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

		private PopsicleList<CCRushLevel> levelInfos_;

		private int memoizedSerializedSize;

		public static CCRushData DefaultInstance => null;

		public override CCRushData DefaultInstanceForType => null;

		protected override CCRushData ThisMessage => null;

		public bool HasSumGames => false;

		public int SumGames => 0;

		public bool HasWinGames => false;

		public int WinGames => 0;

		public bool HasLoseGames => false;

		public int LoseGames => 0;

		public IList<CCRushLevel> LevelInfosList => null;

		public int LevelInfosCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRushData()
		{
		}

		public CCRushLevel GetLevelInfos(int index)
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

		public static CCRushData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRushData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRushData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRushData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRushData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRushData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRushData MakeReadOnly()
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

		public static Builder CreateBuilder(CCRushData prototype)
		{
			return null;
		}

		static CCRushData()
		{
		}
	}
}
