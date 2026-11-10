using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBingoLevel : GeneratedMessageLite<CCBingoLevel, CCBingoLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBingoLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCBingoLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBingoLevel MessageBeingBuilt => null;

			public override CCBingoLevel DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCBingoLevel cloneFrom)
			{
			}

			private CCBingoLevel PrepareBuilder()
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

			public override CCBingoLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBingoLevel other)
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
		}

		private static readonly CCBingoLevel defaultInstance;

		private static readonly string[] _cCBingoLevelFieldNames;

		private static readonly uint[] _cCBingoLevelFieldTags;

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

		private int memoizedSerializedSize;

		public static CCBingoLevel DefaultInstance => null;

		public override CCBingoLevel DefaultInstanceForType => null;

		protected override CCBingoLevel ThisMessage => null;

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

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBingoLevel()
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

		public static CCBingoLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBingoLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBingoLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBingoLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCBingoLevel prototype)
		{
			return null;
		}

		static CCBingoLevel()
		{
		}
	}
}
