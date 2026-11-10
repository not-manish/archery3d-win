using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestReward : GeneratedMessageLite<CCChestReward, CCChestReward.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestReward, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestReward result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestReward MessageBeingBuilt => null;

			public override CCChestReward DefaultInstanceForType => null;

			public bool HasGold => false;

			public int Gold
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGem => false;

			public int Gem
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> CardEquipKindList => null;

			public int CardEquipKindCount => 0;

			public IPopsicleList<int> CardEquipCountList => null;

			public int CardEquipCountCount => 0;

			public IPopsicleList<int> ArrowIdList => null;

			public int ArrowIdCount => 0;

			public IPopsicleList<int> ArrowNumList => null;

			public int ArrowNumCount => 0;

			public bool HasArenaTicketClassic => false;

			public int ArenaTicketClassic
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArenaTicketGrand => false;

			public int ArenaTicketGrand
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> LTBEquipTypeIdsList => null;

			public int LTBEquipTypeIdsCount => 0;

			public bool HasHasExtraReward => false;

			public bool HasExtraReward
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasChestExtra => false;

			public CCChestExtra ChestExtra
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

			internal Builder(CCChestReward cloneFrom)
			{
			}

			private CCChestReward PrepareBuilder()
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

			public override CCChestReward BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestReward other)
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

			public Builder SetGold(int value)
			{
				return null;
			}

			public Builder ClearGold()
			{
				return null;
			}

			public Builder SetGem(int value)
			{
				return null;
			}

			public Builder ClearGem()
			{
				return null;
			}

			public int GetCardEquipKind(int index)
			{
				return 0;
			}

			public Builder SetCardEquipKind(int index, int value)
			{
				return null;
			}

			public Builder AddCardEquipKind(int value)
			{
				return null;
			}

			public Builder AddRangeCardEquipKind(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearCardEquipKind()
			{
				return null;
			}

			public int GetCardEquipCount(int index)
			{
				return 0;
			}

			public Builder SetCardEquipCount(int index, int value)
			{
				return null;
			}

			public Builder AddCardEquipCount(int value)
			{
				return null;
			}

			public Builder AddRangeCardEquipCount(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearCardEquipCount()
			{
				return null;
			}

			public int GetArrowId(int index)
			{
				return 0;
			}

			public Builder SetArrowId(int index, int value)
			{
				return null;
			}

			public Builder AddArrowId(int value)
			{
				return null;
			}

			public Builder AddRangeArrowId(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearArrowId()
			{
				return null;
			}

			public int GetArrowNum(int index)
			{
				return 0;
			}

			public Builder SetArrowNum(int index, int value)
			{
				return null;
			}

			public Builder AddArrowNum(int value)
			{
				return null;
			}

			public Builder AddRangeArrowNum(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearArrowNum()
			{
				return null;
			}

			public Builder SetArenaTicketClassic(int value)
			{
				return null;
			}

			public Builder ClearArenaTicketClassic()
			{
				return null;
			}

			public Builder SetArenaTicketGrand(int value)
			{
				return null;
			}

			public Builder ClearArenaTicketGrand()
			{
				return null;
			}

			public int GetLTBEquipTypeIds(int index)
			{
				return 0;
			}

			public Builder SetLTBEquipTypeIds(int index, int value)
			{
				return null;
			}

			public Builder AddLTBEquipTypeIds(int value)
			{
				return null;
			}

			public Builder AddRangeLTBEquipTypeIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearLTBEquipTypeIds()
			{
				return null;
			}

			public Builder SetHasExtraReward(bool value)
			{
				return null;
			}

			public Builder ClearHasExtraReward()
			{
				return null;
			}

			public Builder SetChestExtra(CCChestExtra value)
			{
				return null;
			}

			public Builder SetChestExtra(CCChestExtra.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestExtra(CCChestExtra value)
			{
				return null;
			}

			public Builder ClearChestExtra()
			{
				return null;
			}
		}

		private static readonly CCChestReward defaultInstance;

		private static readonly string[] _cCChestRewardFieldNames;

		private static readonly uint[] _cCChestRewardFieldTags;

		public const int GoldFieldNumber = 1;

		private bool hasGold;

		private int gold_;

		public const int GemFieldNumber = 2;

		private bool hasGem;

		private int gem_;

		public const int CardEquipKindFieldNumber = 3;

		private PopsicleList<int> cardEquipKind_;

		public const int CardEquipCountFieldNumber = 4;

		private PopsicleList<int> cardEquipCount_;

		public const int ArrowIdFieldNumber = 5;

		private PopsicleList<int> arrowId_;

		public const int ArrowNumFieldNumber = 6;

		private PopsicleList<int> arrowNum_;

		public const int ArenaTicketClassicFieldNumber = 7;

		private bool hasArenaTicketClassic;

		private int arenaTicketClassic_;

		public const int ArenaTicketGrandFieldNumber = 8;

		private bool hasArenaTicketGrand;

		private int arenaTicketGrand_;

		public const int LTBEquipTypeIdsFieldNumber = 9;

		private PopsicleList<int> lTBEquipTypeIds_;

		public const int HasExtraRewardFieldNumber = 10;

		private bool hasHasExtraReward;

		private bool hasExtraReward_;

		public const int ChestExtraFieldNumber = 11;

		private bool hasChestExtra;

		private CCChestExtra chestExtra_;

		private int memoizedSerializedSize;

		public static CCChestReward DefaultInstance => null;

		public override CCChestReward DefaultInstanceForType => null;

		protected override CCChestReward ThisMessage => null;

		public bool HasGold => false;

		public int Gold => 0;

		public bool HasGem => false;

		public int Gem => 0;

		public IList<int> CardEquipKindList => null;

		public int CardEquipKindCount => 0;

		public IList<int> CardEquipCountList => null;

		public int CardEquipCountCount => 0;

		public IList<int> ArrowIdList => null;

		public int ArrowIdCount => 0;

		public IList<int> ArrowNumList => null;

		public int ArrowNumCount => 0;

		public bool HasArenaTicketClassic => false;

		public int ArenaTicketClassic => 0;

		public bool HasArenaTicketGrand => false;

		public int ArenaTicketGrand => 0;

		public IList<int> LTBEquipTypeIdsList => null;

		public int LTBEquipTypeIdsCount => 0;

		public bool HasHasExtraReward => false;

		public bool HasExtraReward => false;

		public bool HasChestExtra => false;

		public CCChestExtra ChestExtra => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestReward()
		{
		}

		public int GetCardEquipKind(int index)
		{
			return 0;
		}

		public int GetCardEquipCount(int index)
		{
			return 0;
		}

		public int GetArrowId(int index)
		{
			return 0;
		}

		public int GetArrowNum(int index)
		{
			return 0;
		}

		public int GetLTBEquipTypeIds(int index)
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

		public static CCChestReward ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestReward ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestReward ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestReward ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestReward ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestReward ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestReward ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestReward ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestReward ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestReward ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestReward MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestReward prototype)
		{
			return null;
		}

		static CCChestReward()
		{
		}
	}
}
