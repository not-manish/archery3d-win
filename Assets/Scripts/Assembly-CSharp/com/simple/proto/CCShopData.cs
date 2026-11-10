using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCShopData : GeneratedMessageLite<CCShopData, CCShopData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCShopData, Builder>
		{
			private bool resultIsReadOnly;

			private CCShopData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCShopData MessageBeingBuilt => null;

			public override CCShopData DefaultInstanceForType => null;

			public bool HasUpdateTimeMil => false;

			public long UpdateTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasBlueCardTypeId => false;

			public int BlueCardTypeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBlueCardBuyedTimes => false;

			public int BlueCardBuyedTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPurpleCardTypeId => false;

			public int PurpleCardTypeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPurpleCardBuyedTimes => false;

			public int PurpleCardBuyedTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrangeCardTypeId => false;

			public int OrangeCardTypeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrangeCardBuyedTimes => false;

			public int OrangeCardBuyedTimes
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestGoldId => false;

			public int ChestGoldId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestPlatinumId => false;

			public int ChestPlatinumId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestDiamondId => false;

			public int ChestDiamondId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasId1Unlocked => false;

			public bool Id1Unlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasId1FreeId => false;

			public int Id1FreeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasId1GetStartTimeMil => false;

			public long Id1GetStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasId2Unlocked => false;

			public bool Id2Unlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasId2RewardId => false;

			public int Id2RewardId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasId2BuyStartTimeMil => false;

			public long Id2BuyStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasId6Unlocked => false;

			public bool Id6Unlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasId6RewardId => false;

			public int Id6RewardId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasId6BuyStartTimeMil => false;

			public long Id6BuyStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCShopData cloneFrom)
			{
			}

			private CCShopData PrepareBuilder()
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

			public override CCShopData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCShopData other)
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

			public Builder SetUpdateTimeMil(long value)
			{
				return null;
			}

			public Builder ClearUpdateTimeMil()
			{
				return null;
			}

			public Builder SetBlueCardTypeId(int value)
			{
				return null;
			}

			public Builder ClearBlueCardTypeId()
			{
				return null;
			}

			public Builder SetBlueCardBuyedTimes(int value)
			{
				return null;
			}

			public Builder ClearBlueCardBuyedTimes()
			{
				return null;
			}

			public Builder SetPurpleCardTypeId(int value)
			{
				return null;
			}

			public Builder ClearPurpleCardTypeId()
			{
				return null;
			}

			public Builder SetPurpleCardBuyedTimes(int value)
			{
				return null;
			}

			public Builder ClearPurpleCardBuyedTimes()
			{
				return null;
			}

			public Builder SetOrangeCardTypeId(int value)
			{
				return null;
			}

			public Builder ClearOrangeCardTypeId()
			{
				return null;
			}

			public Builder SetOrangeCardBuyedTimes(int value)
			{
				return null;
			}

			public Builder ClearOrangeCardBuyedTimes()
			{
				return null;
			}

			public Builder SetChestGoldId(int value)
			{
				return null;
			}

			public Builder ClearChestGoldId()
			{
				return null;
			}

			public Builder SetChestPlatinumId(int value)
			{
				return null;
			}

			public Builder ClearChestPlatinumId()
			{
				return null;
			}

			public Builder SetChestDiamondId(int value)
			{
				return null;
			}

			public Builder ClearChestDiamondId()
			{
				return null;
			}

			public Builder SetId1Unlocked(bool value)
			{
				return null;
			}

			public Builder ClearId1Unlocked()
			{
				return null;
			}

			public Builder SetId1FreeId(int value)
			{
				return null;
			}

			public Builder ClearId1FreeId()
			{
				return null;
			}

			public Builder SetId1GetStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearId1GetStartTimeMil()
			{
				return null;
			}

			public Builder SetId2Unlocked(bool value)
			{
				return null;
			}

			public Builder ClearId2Unlocked()
			{
				return null;
			}

			public Builder SetId2RewardId(int value)
			{
				return null;
			}

			public Builder ClearId2RewardId()
			{
				return null;
			}

			public Builder SetId2BuyStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearId2BuyStartTimeMil()
			{
				return null;
			}

			public Builder SetId6Unlocked(bool value)
			{
				return null;
			}

			public Builder ClearId6Unlocked()
			{
				return null;
			}

			public Builder SetId6RewardId(int value)
			{
				return null;
			}

			public Builder ClearId6RewardId()
			{
				return null;
			}

			public Builder SetId6BuyStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearId6BuyStartTimeMil()
			{
				return null;
			}
		}

		private static readonly CCShopData defaultInstance;

		private static readonly string[] _cCShopDataFieldNames;

		private static readonly uint[] _cCShopDataFieldTags;

		public const int UpdateTimeMilFieldNumber = 1;

		private bool hasUpdateTimeMil;

		private long updateTimeMil_;

		public const int BlueCardTypeIdFieldNumber = 2;

		private bool hasBlueCardTypeId;

		private int blueCardTypeId_;

		public const int BlueCardBuyedTimesFieldNumber = 3;

		private bool hasBlueCardBuyedTimes;

		private int blueCardBuyedTimes_;

		public const int PurpleCardTypeIdFieldNumber = 4;

		private bool hasPurpleCardTypeId;

		private int purpleCardTypeId_;

		public const int PurpleCardBuyedTimesFieldNumber = 5;

		private bool hasPurpleCardBuyedTimes;

		private int purpleCardBuyedTimes_;

		public const int OrangeCardTypeIdFieldNumber = 6;

		private bool hasOrangeCardTypeId;

		private int orangeCardTypeId_;

		public const int OrangeCardBuyedTimesFieldNumber = 7;

		private bool hasOrangeCardBuyedTimes;

		private int orangeCardBuyedTimes_;

		public const int ChestGoldIdFieldNumber = 8;

		private bool hasChestGoldId;

		private int chestGoldId_;

		public const int ChestPlatinumIdFieldNumber = 9;

		private bool hasChestPlatinumId;

		private int chestPlatinumId_;

		public const int ChestDiamondIdFieldNumber = 10;

		private bool hasChestDiamondId;

		private int chestDiamondId_;

		public const int Id1UnlockedFieldNumber = 11;

		private bool hasId1Unlocked;

		private bool id1Unlocked_;

		public const int Id1FreeIdFieldNumber = 12;

		private bool hasId1FreeId;

		private int id1FreeId_;

		public const int Id1GetStartTimeMilFieldNumber = 13;

		private bool hasId1GetStartTimeMil;

		private long id1GetStartTimeMil_;

		public const int Id2UnlockedFieldNumber = 14;

		private bool hasId2Unlocked;

		private bool id2Unlocked_;

		public const int Id2RewardIdFieldNumber = 15;

		private bool hasId2RewardId;

		private int id2RewardId_;

		public const int Id2BuyStartTimeMilFieldNumber = 16;

		private bool hasId2BuyStartTimeMil;

		private long id2BuyStartTimeMil_;

		public const int Id6UnlockedFieldNumber = 17;

		private bool hasId6Unlocked;

		private bool id6Unlocked_;

		public const int Id6RewardIdFieldNumber = 18;

		private bool hasId6RewardId;

		private int id6RewardId_;

		public const int Id6BuyStartTimeMilFieldNumber = 19;

		private bool hasId6BuyStartTimeMil;

		private long id6BuyStartTimeMil_;

		private int memoizedSerializedSize;

		public static CCShopData DefaultInstance => null;

		public override CCShopData DefaultInstanceForType => null;

		protected override CCShopData ThisMessage => null;

		public bool HasUpdateTimeMil => false;

		public long UpdateTimeMil => 0L;

		public bool HasBlueCardTypeId => false;

		public int BlueCardTypeId => 0;

		public bool HasBlueCardBuyedTimes => false;

		public int BlueCardBuyedTimes => 0;

		public bool HasPurpleCardTypeId => false;

		public int PurpleCardTypeId => 0;

		public bool HasPurpleCardBuyedTimes => false;

		public int PurpleCardBuyedTimes => 0;

		public bool HasOrangeCardTypeId => false;

		public int OrangeCardTypeId => 0;

		public bool HasOrangeCardBuyedTimes => false;

		public int OrangeCardBuyedTimes => 0;

		public bool HasChestGoldId => false;

		public int ChestGoldId => 0;

		public bool HasChestPlatinumId => false;

		public int ChestPlatinumId => 0;

		public bool HasChestDiamondId => false;

		public int ChestDiamondId => 0;

		public bool HasId1Unlocked => false;

		public bool Id1Unlocked => false;

		public bool HasId1FreeId => false;

		public int Id1FreeId => 0;

		public bool HasId1GetStartTimeMil => false;

		public long Id1GetStartTimeMil => 0L;

		public bool HasId2Unlocked => false;

		public bool Id2Unlocked => false;

		public bool HasId2RewardId => false;

		public int Id2RewardId => 0;

		public bool HasId2BuyStartTimeMil => false;

		public long Id2BuyStartTimeMil => 0L;

		public bool HasId6Unlocked => false;

		public bool Id6Unlocked => false;

		public bool HasId6RewardId => false;

		public int Id6RewardId => 0;

		public bool HasId6BuyStartTimeMil => false;

		public long Id6BuyStartTimeMil => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCShopData()
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

		public static CCShopData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCShopData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShopData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCShopData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShopData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCShopData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShopData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCShopData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShopData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCShopData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCShopData MakeReadOnly()
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

		public static Builder CreateBuilder(CCShopData prototype)
		{
			return null;
		}

		static CCShopData()
		{
		}
	}
}
