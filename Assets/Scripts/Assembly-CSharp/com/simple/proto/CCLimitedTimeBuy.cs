using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLimitedTimeBuy : GeneratedMessageLite<CCLimitedTimeBuy, CCLimitedTimeBuy.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLimitedTimeBuy, Builder>
		{
			private bool resultIsReadOnly;

			private CCLimitedTimeBuy result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLimitedTimeBuy MessageBeingBuilt => null;

			public override CCLimitedTimeBuy DefaultInstanceForType => null;

			public bool HasNewPlayerPack => false;

			public CCLimitedTimeBuyItem NewPlayerPack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLevelUnlocPack => false;

			public CCLimitedTimeBuyItem LevelUnlocPack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasArenaPack => false;

			public CCLimitedTimeBuyItem ArenaPack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChallengePack => false;

			public CCLimitedTimeBuyItem ChallengePack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasContinueLosesPack => false;

			public CCLimitedTimeBuyItem ContinueLosesPack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasEquipPack => false;

			public CCLimitedTimeBuyItem EquipPack
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasEquip2Pack => false;

			public CCLimitedTimeBuyItem Equip2Pack
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

			internal Builder(CCLimitedTimeBuy cloneFrom)
			{
			}

			private CCLimitedTimeBuy PrepareBuilder()
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

			public override CCLimitedTimeBuy BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLimitedTimeBuy other)
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

			public Builder SetNewPlayerPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetNewPlayerPack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeNewPlayerPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearNewPlayerPack()
			{
				return null;
			}

			public Builder SetLevelUnlocPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetLevelUnlocPack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeLevelUnlocPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearLevelUnlocPack()
			{
				return null;
			}

			public Builder SetArenaPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetArenaPack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeArenaPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearArenaPack()
			{
				return null;
			}

			public Builder SetChallengePack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetChallengePack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChallengePack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearChallengePack()
			{
				return null;
			}

			public Builder SetContinueLosesPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetContinueLosesPack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeContinueLosesPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearContinueLosesPack()
			{
				return null;
			}

			public Builder SetEquipPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetEquipPack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeEquipPack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearEquipPack()
			{
				return null;
			}

			public Builder SetEquip2Pack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder SetEquip2Pack(CCLimitedTimeBuyItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeEquip2Pack(CCLimitedTimeBuyItem value)
			{
				return null;
			}

			public Builder ClearEquip2Pack()
			{
				return null;
			}
		}

		private static readonly CCLimitedTimeBuy defaultInstance;

		private static readonly string[] _cCLimitedTimeBuyFieldNames;

		private static readonly uint[] _cCLimitedTimeBuyFieldTags;

		public const int NewPlayerPackFieldNumber = 1;

		private bool hasNewPlayerPack;

		private CCLimitedTimeBuyItem newPlayerPack_;

		public const int LevelUnlocPackFieldNumber = 2;

		private bool hasLevelUnlocPack;

		private CCLimitedTimeBuyItem levelUnlocPack_;

		public const int ArenaPackFieldNumber = 3;

		private bool hasArenaPack;

		private CCLimitedTimeBuyItem arenaPack_;

		public const int ChallengePackFieldNumber = 4;

		private bool hasChallengePack;

		private CCLimitedTimeBuyItem challengePack_;

		public const int ContinueLosesPackFieldNumber = 5;

		private bool hasContinueLosesPack;

		private CCLimitedTimeBuyItem continueLosesPack_;

		public const int EquipPackFieldNumber = 6;

		private bool hasEquipPack;

		private CCLimitedTimeBuyItem equipPack_;

		public const int Equip2PackFieldNumber = 7;

		private bool hasEquip2Pack;

		private CCLimitedTimeBuyItem equip2Pack_;

		private int memoizedSerializedSize;

		public static CCLimitedTimeBuy DefaultInstance => null;

		public override CCLimitedTimeBuy DefaultInstanceForType => null;

		protected override CCLimitedTimeBuy ThisMessage => null;

		public bool HasNewPlayerPack => false;

		public CCLimitedTimeBuyItem NewPlayerPack => null;

		public bool HasLevelUnlocPack => false;

		public CCLimitedTimeBuyItem LevelUnlocPack => null;

		public bool HasArenaPack => false;

		public CCLimitedTimeBuyItem ArenaPack => null;

		public bool HasChallengePack => false;

		public CCLimitedTimeBuyItem ChallengePack => null;

		public bool HasContinueLosesPack => false;

		public CCLimitedTimeBuyItem ContinueLosesPack => null;

		public bool HasEquipPack => false;

		public CCLimitedTimeBuyItem EquipPack => null;

		public bool HasEquip2Pack => false;

		public CCLimitedTimeBuyItem Equip2Pack => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLimitedTimeBuy()
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

		public static CCLimitedTimeBuy ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLimitedTimeBuy ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLimitedTimeBuy MakeReadOnly()
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

		public static Builder CreateBuilder(CCLimitedTimeBuy prototype)
		{
			return null;
		}

		static CCLimitedTimeBuy()
		{
		}
	}
}
