using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCClassicData : GeneratedMessageLite<CCClassicData, CCClassicData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCClassicData, Builder>
		{
			private bool resultIsReadOnly;

			private CCClassicData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCClassicData MessageBeingBuilt => null;

			public override CCClassicData DefaultInstanceForType => null;

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

			public IPopsicleList<CCClassicLevel> ClassicLevelInfosList => null;

			public int ClassicLevelInfosCount => 0;

			public Builder()
			{
			}

			internal Builder(CCClassicData cloneFrom)
			{
			}

			private CCClassicData PrepareBuilder()
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

			public override CCClassicData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCClassicData other)
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

			public CCClassicLevel GetClassicLevelInfos(int index)
			{
				return null;
			}

			public Builder SetClassicLevelInfos(int index, CCClassicLevel value)
			{
				return null;
			}

			public Builder SetClassicLevelInfos(int index, CCClassicLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddClassicLevelInfos(CCClassicLevel value)
			{
				return null;
			}

			public Builder AddClassicLevelInfos(CCClassicLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeClassicLevelInfos(IEnumerable<CCClassicLevel> values)
			{
				return null;
			}

			public Builder ClearClassicLevelInfos()
			{
				return null;
			}
		}

		private static readonly CCClassicData defaultInstance;

		private static readonly string[] _cCClassicDataFieldNames;

		private static readonly uint[] _cCClassicDataFieldTags;

		public const int SumGamesFieldNumber = 1;

		private bool hasSumGames;

		private int sumGames_;

		public const int WinGamesFieldNumber = 2;

		private bool hasWinGames;

		private int winGames_;

		public const int LoseGamesFieldNumber = 3;

		private bool hasLoseGames;

		private int loseGames_;

		public const int ClassicLevelInfosFieldNumber = 4;

		private PopsicleList<CCClassicLevel> classicLevelInfos_;

		private int memoizedSerializedSize;

		public static CCClassicData DefaultInstance => null;

		public override CCClassicData DefaultInstanceForType => null;

		protected override CCClassicData ThisMessage => null;

		public bool HasSumGames => false;

		public int SumGames => 0;

		public bool HasWinGames => false;

		public int WinGames => 0;

		public bool HasLoseGames => false;

		public int LoseGames => 0;

		public IList<CCClassicLevel> ClassicLevelInfosList => null;

		public int ClassicLevelInfosCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCClassicData()
		{
		}

		public CCClassicLevel GetClassicLevelInfos(int index)
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

		public static CCClassicData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCClassicData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCClassicData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCClassicData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCClassicData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCClassicData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCClassicData MakeReadOnly()
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

		public static Builder CreateBuilder(CCClassicData prototype)
		{
			return null;
		}

		static CCClassicData()
		{
		}
	}
}
