using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRushLevel : GeneratedMessageLite<CCRushLevel, CCRushLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRushLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCRushLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRushLevel MessageBeingBuilt => null;

			public override CCRushLevel DefaultInstanceForType => null;

			public bool HasId => false;

			public int Id
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHasUnlocked => false;

			public bool HasUnlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasGetTrophy => false;

			public int GetTrophy
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

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

			public bool HasAveSumCount => false;

			public int AveSumCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAveRing => false;

			public float AveRing
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasAveWinCount => false;

			public int AveWinCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIsContinueWin => false;

			public bool IsContinueWin
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasContinueCount => false;

			public int ContinueCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> LastGameScoresList => null;

			public int LastGameScoresCount => 0;

			public Builder()
			{
			}

			internal Builder(CCRushLevel cloneFrom)
			{
			}

			private CCRushLevel PrepareBuilder()
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

			public override CCRushLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRushLevel other)
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

			public Builder SetId(int value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}

			public Builder SetHasUnlocked(bool value)
			{
				return null;
			}

			public Builder ClearHasUnlocked()
			{
				return null;
			}

			public Builder SetGetTrophy(int value)
			{
				return null;
			}

			public Builder ClearGetTrophy()
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

			public Builder SetAveSumCount(int value)
			{
				return null;
			}

			public Builder ClearAveSumCount()
			{
				return null;
			}

			public Builder SetAveRing(float value)
			{
				return null;
			}

			public Builder ClearAveRing()
			{
				return null;
			}

			public Builder SetAveWinCount(int value)
			{
				return null;
			}

			public Builder ClearAveWinCount()
			{
				return null;
			}

			public Builder SetIsContinueWin(bool value)
			{
				return null;
			}

			public Builder ClearIsContinueWin()
			{
				return null;
			}

			public Builder SetContinueCount(int value)
			{
				return null;
			}

			public Builder ClearContinueCount()
			{
				return null;
			}

			public int GetLastGameScores(int index)
			{
				return 0;
			}

			public Builder SetLastGameScores(int index, int value)
			{
				return null;
			}

			public Builder AddLastGameScores(int value)
			{
				return null;
			}

			public Builder AddRangeLastGameScores(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearLastGameScores()
			{
				return null;
			}
		}

		private static readonly CCRushLevel defaultInstance;

		private static readonly string[] _cCRushLevelFieldNames;

		private static readonly uint[] _cCRushLevelFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private int id_;

		public const int HasUnlockedFieldNumber = 2;

		private bool hasHasUnlocked;

		private bool hasUnlocked_;

		public const int GetTrophyFieldNumber = 3;

		private bool hasGetTrophy;

		private int getTrophy_;

		public const int SumGamesFieldNumber = 4;

		private bool hasSumGames;

		private int sumGames_;

		public const int WinGamesFieldNumber = 5;

		private bool hasWinGames;

		private int winGames_;

		public const int LoseGamesFieldNumber = 6;

		private bool hasLoseGames;

		private int loseGames_;

		public const int AveSumCountFieldNumber = 7;

		private bool hasAveSumCount;

		private int aveSumCount_;

		public const int AveRingFieldNumber = 8;

		private bool hasAveRing;

		private float aveRing_;

		public const int AveWinCountFieldNumber = 11;

		private bool hasAveWinCount;

		private int aveWinCount_;

		public const int IsContinueWinFieldNumber = 9;

		private bool hasIsContinueWin;

		private bool isContinueWin_;

		public const int ContinueCountFieldNumber = 10;

		private bool hasContinueCount;

		private int continueCount_;

		public const int LastGameScoresFieldNumber = 12;

		private PopsicleList<int> lastGameScores_;

		private int memoizedSerializedSize;

		public static CCRushLevel DefaultInstance => null;

		public override CCRushLevel DefaultInstanceForType => null;

		protected override CCRushLevel ThisMessage => null;

		public bool HasId => false;

		public int Id => 0;

		public bool HasHasUnlocked => false;

		public bool HasUnlocked => false;

		public bool HasGetTrophy => false;

		public int GetTrophy => 0;

		public bool HasSumGames => false;

		public int SumGames => 0;

		public bool HasWinGames => false;

		public int WinGames => 0;

		public bool HasLoseGames => false;

		public int LoseGames => 0;

		public bool HasAveSumCount => false;

		public int AveSumCount => 0;

		public bool HasAveRing => false;

		public float AveRing => 0f;

		public bool HasAveWinCount => false;

		public int AveWinCount => 0;

		public bool HasIsContinueWin => false;

		public bool IsContinueWin => false;

		public bool HasContinueCount => false;

		public int ContinueCount => 0;

		public IList<int> LastGameScoresList => null;

		public int LastGameScoresCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRushLevel()
		{
		}

		public int GetLastGameScores(int index)
		{
			return 0;
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

		public static CCRushLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRushLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRushLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRushLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCRushLevel prototype)
		{
			return null;
		}

		static CCRushLevel()
		{
		}
	}
}
