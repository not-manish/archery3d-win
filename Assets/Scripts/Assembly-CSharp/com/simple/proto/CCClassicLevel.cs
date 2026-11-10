using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCClassicLevel : GeneratedMessageLite<CCClassicLevel, CCClassicLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCClassicLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCClassicLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCClassicLevel MessageBeingBuilt => null;

			public override CCClassicLevel DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCClassicLevel cloneFrom)
			{
			}

			private CCClassicLevel PrepareBuilder()
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

			public override CCClassicLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCClassicLevel other)
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
		}

		private static readonly CCClassicLevel defaultInstance;

		private static readonly string[] _cCClassicLevelFieldNames;

		private static readonly uint[] _cCClassicLevelFieldTags;

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

		private int memoizedSerializedSize;

		public static CCClassicLevel DefaultInstance => null;

		public override CCClassicLevel DefaultInstanceForType => null;

		protected override CCClassicLevel ThisMessage => null;

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

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCClassicLevel()
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

		public static CCClassicLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCClassicLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCClassicLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCClassicLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCClassicLevel prototype)
		{
			return null;
		}

		static CCClassicLevel()
		{
		}
	}
}
