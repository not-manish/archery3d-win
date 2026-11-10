using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayerGameModeState : GeneratedMessageLite<CCPlayerGameModeState, CCPlayerGameModeState.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayerGameModeState, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayerGameModeState result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayerGameModeState MessageBeingBuilt => null;

			public override CCPlayerGameModeState DefaultInstanceForType => null;

			public bool HasHasInitData => false;

			public bool HasInitData
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasSerLockedClassic => false;

			public bool SerLockedClassic
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasSerLockedRush => false;

			public bool SerLockedRush
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasSerLockedBingo => false;

			public bool SerLockedBingo
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasSerLockedArena => false;

			public bool SerLockedArena
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasSerLockedChallenge => false;

			public bool SerLockedChallenge
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlaUnlocClassic => false;

			public bool PlaUnlocClassic
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlaUnlocRush => false;

			public bool PlaUnlocRush
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlaUnlocBingo => false;

			public bool PlaUnlocBingo
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlaUnlocArena => false;

			public bool PlaUnlocArena
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPlaUnlocChallenge => false;

			public bool PlaUnlocChallenge
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCPlayerGameModeState cloneFrom)
			{
			}

			private CCPlayerGameModeState PrepareBuilder()
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

			public override CCPlayerGameModeState BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayerGameModeState other)
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

			public Builder SetHasInitData(bool value)
			{
				return null;
			}

			public Builder ClearHasInitData()
			{
				return null;
			}

			public Builder SetSerLockedClassic(bool value)
			{
				return null;
			}

			public Builder ClearSerLockedClassic()
			{
				return null;
			}

			public Builder SetSerLockedRush(bool value)
			{
				return null;
			}

			public Builder ClearSerLockedRush()
			{
				return null;
			}

			public Builder SetSerLockedBingo(bool value)
			{
				return null;
			}

			public Builder ClearSerLockedBingo()
			{
				return null;
			}

			public Builder SetSerLockedArena(bool value)
			{
				return null;
			}

			public Builder ClearSerLockedArena()
			{
				return null;
			}

			public Builder SetSerLockedChallenge(bool value)
			{
				return null;
			}

			public Builder ClearSerLockedChallenge()
			{
				return null;
			}

			public Builder SetPlaUnlocClassic(bool value)
			{
				return null;
			}

			public Builder ClearPlaUnlocClassic()
			{
				return null;
			}

			public Builder SetPlaUnlocRush(bool value)
			{
				return null;
			}

			public Builder ClearPlaUnlocRush()
			{
				return null;
			}

			public Builder SetPlaUnlocBingo(bool value)
			{
				return null;
			}

			public Builder ClearPlaUnlocBingo()
			{
				return null;
			}

			public Builder SetPlaUnlocArena(bool value)
			{
				return null;
			}

			public Builder ClearPlaUnlocArena()
			{
				return null;
			}

			public Builder SetPlaUnlocChallenge(bool value)
			{
				return null;
			}

			public Builder ClearPlaUnlocChallenge()
			{
				return null;
			}
		}

		private static readonly CCPlayerGameModeState defaultInstance;

		private static readonly string[] _cCPlayerGameModeStateFieldNames;

		private static readonly uint[] _cCPlayerGameModeStateFieldTags;

		public const int HasInitDataFieldNumber = 1;

		private bool hasHasInitData;

		private bool hasInitData_;

		public const int SerLockedClassicFieldNumber = 2;

		private bool hasSerLockedClassic;

		private bool serLockedClassic_;

		public const int SerLockedRushFieldNumber = 3;

		private bool hasSerLockedRush;

		private bool serLockedRush_;

		public const int SerLockedBingoFieldNumber = 4;

		private bool hasSerLockedBingo;

		private bool serLockedBingo_;

		public const int SerLockedArenaFieldNumber = 5;

		private bool hasSerLockedArena;

		private bool serLockedArena_;

		public const int SerLockedChallengeFieldNumber = 6;

		private bool hasSerLockedChallenge;

		private bool serLockedChallenge_;

		public const int PlaUnlocClassicFieldNumber = 7;

		private bool hasPlaUnlocClassic;

		private bool plaUnlocClassic_;

		public const int PlaUnlocRushFieldNumber = 8;

		private bool hasPlaUnlocRush;

		private bool plaUnlocRush_;

		public const int PlaUnlocBingoFieldNumber = 9;

		private bool hasPlaUnlocBingo;

		private bool plaUnlocBingo_;

		public const int PlaUnlocArenaFieldNumber = 10;

		private bool hasPlaUnlocArena;

		private bool plaUnlocArena_;

		public const int PlaUnlocChallengeFieldNumber = 11;

		private bool hasPlaUnlocChallenge;

		private bool plaUnlocChallenge_;

		private int memoizedSerializedSize;

		public static CCPlayerGameModeState DefaultInstance => null;

		public override CCPlayerGameModeState DefaultInstanceForType => null;

		protected override CCPlayerGameModeState ThisMessage => null;

		public bool HasHasInitData => false;

		public bool HasInitData => false;

		public bool HasSerLockedClassic => false;

		public bool SerLockedClassic => false;

		public bool HasSerLockedRush => false;

		public bool SerLockedRush => false;

		public bool HasSerLockedBingo => false;

		public bool SerLockedBingo => false;

		public bool HasSerLockedArena => false;

		public bool SerLockedArena => false;

		public bool HasSerLockedChallenge => false;

		public bool SerLockedChallenge => false;

		public bool HasPlaUnlocClassic => false;

		public bool PlaUnlocClassic => false;

		public bool HasPlaUnlocRush => false;

		public bool PlaUnlocRush => false;

		public bool HasPlaUnlocBingo => false;

		public bool PlaUnlocBingo => false;

		public bool HasPlaUnlocArena => false;

		public bool PlaUnlocArena => false;

		public bool HasPlaUnlocChallenge => false;

		public bool PlaUnlocChallenge => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayerGameModeState()
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

		public static CCPlayerGameModeState ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayerGameModeState ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayerGameModeState MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayerGameModeState prototype)
		{
			return null;
		}

		static CCPlayerGameModeState()
		{
		}
	}
}
